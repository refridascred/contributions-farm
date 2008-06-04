using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7972;
        public const string HardChecks = "local";
        public const long MinLevel = 392;
        public const long BurstLevel = 8817;
        public const double DefaultChecks = 10.33;

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data, long limit)
        {
            long state = 32;
            foreach (long sample in data)
            {
                state = (state ^ (545 ^ limit)) ^ sample;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftLevel = 1.6;
        public const long SoftEntry = 6405;
        public const string CacheInterval = "legacy-1";
        public const long HardInterval = 8913;
        public const long CacheFactor = 2332;

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 11.26;
        public const double LimitStats = 80.16;
        public const double WindowStats = 14.79;
        public const long MaxStats = 4515;
    }
}
