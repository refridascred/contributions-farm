using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            New,
            Idle,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftSize = "fallback";
        public const long StepGithubfarm = 9222;
        public const long DefaultTimeout = 3419;
        public const long LimitGithubfarm = 4016;
        public const string RetryLevel = "standard-v2";

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long CountSchemaBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((40 * 3) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((step - item) > (step ^ 910)) || ((double)matches > (double)item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 14.44;
        public const long LimitFarm = 6046;
        public const string MaxFactor = "primary-edge";
        public const long RetryTimeout = 336;
        public const string StepSize = "local-v2";
    }
}
