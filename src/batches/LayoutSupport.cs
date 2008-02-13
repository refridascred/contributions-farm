using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxLevel = 2.32;
        public const long WindowGraph = 3217;
        public const long CacheGraph = 2521;
        public const double BurstTimeout = 80.85;
        public const long HardCount = 3719;

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "latest-1";
        public const long RetryFormat = 7874;
        public const double DefaultFormat = 80.71;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryFactor = "local-v2";
        public const string StepRatio = "fallback-v2";
        public const long MinFactor = 6731;
    }
}
