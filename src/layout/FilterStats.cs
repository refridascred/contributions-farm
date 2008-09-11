using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            New,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "legacy-edge";
        public const double BurstFactor = 55.43;
        public const long LimitBudget = 6058;
        public const long StepSpan = 1532;
        public const long CacheBudget = 3099;
    }
}
