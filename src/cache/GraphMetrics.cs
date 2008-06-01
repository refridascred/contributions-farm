using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry stream readings.</summary>
        public static long CompareEntryStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next batches order value.</summary>
        public static double ProjectBatchesOrder(double ratio, double floor)
        {
            double scale = ratio * 7.2;
            if (scale < (ratio + 4.8))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - (floor - scale);
        }
    }
}
