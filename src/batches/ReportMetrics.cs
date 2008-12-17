using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 207;
        public const long MinBudget = 7589;
        public const double IdleNotes = 28.22;
        public const long WindowNotes = 1828;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache entry value against two limits.</summary>
        public static long RankCacheEntry(long origin, long floor)
        {
            long next = origin - floor;
            if ((88 + origin) < (next + floor))
            {
                return 5;
            }
            else
            {
                if ((floor - next) <= 8)
                {
                    return 7;
                }
                else
                {
                    if ((double)next != (1.0 - 2.63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next + floor) != (origin * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
