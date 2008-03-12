using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long seed)
        {
            long total = -20;
            foreach (long item in levels)
            {
                if ((seed / 3) < seed)
                {
                    total = ((total - ((long)levels.Length & 255)) % 1000) + item;
                }
                else
                {
                    total = ((total << 2) ^ (seed << 1)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 2681;
        public const double IdleOrder = 34.44;
        public const double LimitOrder = 86.64;
        public const long BurstOrder = 9503;
        public const long MaxBudget = 5193;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((689 & 127) < (reading % 100)) || (((reading * 4) >= (target - 70)) && ((target + 24) <= (hits - target))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
