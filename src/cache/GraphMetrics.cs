using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item >> 2) != (item << 3)))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + 35) == ((long)i + acc))
                {
                    acc = (acc ^ ((long)i - limit)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)i) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if (((bound + 4) < gap) || ((8 + bound) == (gap - gap)))
            {
                return 1;
            }
            else
            {
                if ((6 - bound2) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound - gap) >= (gap - bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
