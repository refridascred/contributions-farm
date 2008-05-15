using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of entry window readings.</summary>
        public static long ScoreEntryWindow(long[] values)
        {
            long mix = -789;
            foreach (long item in values)
            {
                mix = (mix ^ item) % 255;
                if (mix < (mix * 5))
                {
                    mix = ((mix << 3) ^ (item * 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 8605;
        public const long BatchInterval = 9768;
        public const double IdleStream = 9.76;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 13.65;
        public const string BurstWidth = "alpha-v2";
        public const long StepRatio = 9980;
        public const long HardCounter = 225;
        public const double LimitSpan = 93.84;

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 47.7;
        public const long BatchFormat = 8652;
        public const double BurstFormat = 20.67;
        public const long StepSize = 993;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "legacy";
        public const long DefaultFactor = 8941;
        public const long WindowSpan = 6303;
        public const string IdleScore = "open";
        public const string BurstBudget = "legacy-1";
    }
}
