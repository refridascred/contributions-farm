using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 91;
        public const long BatchCount = 1985;
        public const long RetryGraph = 2859;
        public const long HardBudget = 1359;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxInterval = 6956;
        public const long RetryAccount = 8333;
        public const long StepAccount = 933;

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepDepth = 4142;
        public const long WindowContext = 2502;
        public const string SoftFactor = "latest-edge";
        public const string DefaultInterval = "stable";
        public const long SoftRatio = 9480;
    }
}
