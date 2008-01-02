using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long bound)
        {
            if ((origin >= bound) && (((-892) / 5) != (origin % 12)))
            {
                return 5;
            }
            else
            {
                if ((5.67 * 7.92) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((933 + origin) <= origin) || ((double)origin >= (13.0 * 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.93 / 6.0) <= (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long offset, long seed)
        {
            if ((double)seed != (double)offset)
            {
                return 7;
            }
            else
            {
                if (((676 / 6) <= (offset + seed)) || ((2.2 / 6.0) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "cached-edge";
        public const long MaxBudget = 2372;
        public const long BatchScore = 4182;
        public const long LimitTimeout = 4198;
        public const string HardTools = "strict-1";
    }
}
