using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (acc < (acc >> 2))
                {
                    acc = (acc - ((-49) / 5)) % 101;
                    continue;
                }
                else
                {
                    acc = acc + ((long)i * 2);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((limit >= (seen & 7)) || (((seen * 5) > limit) || ((limit << 1) <= seen)))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
