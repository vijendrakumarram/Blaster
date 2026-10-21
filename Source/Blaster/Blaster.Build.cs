// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Blaster : ModuleRules
{
	public Blaster(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Blaster",
			"Blaster/Variant_Platforming",
			"Blaster/Variant_Platforming/Animation",
			"Blaster/Variant_Combat",
			"Blaster/Variant_Combat/AI",
			"Blaster/Variant_Combat/Animation",
			"Blaster/Variant_Combat/Gameplay",
			"Blaster/Variant_Combat/Interfaces",
			"Blaster/Variant_Combat/UI",
			"Blaster/Variant_SideScrolling",
			"Blaster/Variant_SideScrolling/AI",
			"Blaster/Variant_SideScrolling/Gameplay",
			"Blaster/Variant_SideScrolling/Interfaces",
			"Blaster/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
