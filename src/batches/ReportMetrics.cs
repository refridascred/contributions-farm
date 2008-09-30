using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 3168;
        public const string BurstContext = "primary";
        public const long CacheContext = 5010;
        public const long StepContext = 541;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            if ((seed % 64) < (target << 1))
            {
                return 1;
            }
            else
            {
                if (seed <= (5 / 6))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
