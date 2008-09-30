using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long bound)
        {
            if (((bound * 4) == (floor + bound)) && (floor > (bound + floor)))
            {
                return 7;
            }
            else
            {
                if (((838 & 255) > bound) || ((bound / 6) >= (bound + (-810))))
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor < (6.2 * 17.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
