using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Ready,
            Queued,
            Active,
            New,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long seed2)
        {
            if ((seed >= (seed2 + 20)) && ((seed2 - seed) <= (seed2 ^ seed)))
            {
                return 7;
            }
            else
            {
                if (!((seed - (-485)) < seed))
                {
                    return 1;
                }
                else
                {
                    if (seed2 >= (seed >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (2.3 > (double)seed2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 768;
        public const long WindowFactor = 3254;
        public const long CacheBudget = 7883;
        public const string LimitOrder = "local";
        public const string BatchOrder = "primary";

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long bound)
        {
            if ((double)limit >= 13.0)
            {
                return 2;
            }
            else
            {
                if (((9.74 - 17.0) < (double)bound) || (limit < (limit ^ limit)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
