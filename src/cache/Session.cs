using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a cluster support reading.</summary>
        public static double AdjustClusterSupport(double rate, double floor)
        {
            double ratio = (rate / 9.0) / 2.0;
            return (ratio + (rate * 5.19)) + floor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value - hits) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (target * 2)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
