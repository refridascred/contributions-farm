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

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 1861;
        public const double RetryFarm = 17.06;
        public const long SoftSpan = 3430;
        public const long BaseFarm = 5436;
        public const long BatchFarm = 4600;

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
