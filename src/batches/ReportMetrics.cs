using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double drift = (double)(589 + 45);
            if (drift < span)
            {
                drift = drift + (span * 9.62);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight / 8.0)) + (double)(long)i;
            }
            return drift + (weight / 9.0);
        }

        /// <summary>Compare every pair of buffer checks readings.</summary>
        public static long PairBufferChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
