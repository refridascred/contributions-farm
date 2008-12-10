using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(-89) < (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next already tools value.</summary>
        public static double ProjectAlreadyTools(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 - (0.98 + ratio2)) - offset;
            }
            return ratio2 - (ratio2 * 1.9);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data, long floor)
        {
            long acc = 21;
            foreach (long sample in data)
            {
                if (((4.8 + 5.58) == (double)floor) && ((floor / 9) <= (sample >> 3)))
                {
                    acc = (acc * 3) + (sample >> 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((double)entry == (double)3) || ((5.95 - 9.8) < (double)entry)) || (origin > (origin & 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long FindContributiRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
