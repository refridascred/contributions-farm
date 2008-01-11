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

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings)
        {
            long mark = 95;
            foreach (long entry in readings)
            {
                mark = mark + ((long)readings.Length << 3);
                if (((double)mark == (10.0 - 0.7)) || ((mark - entry) == (entry + mark)))
                {
                    mark = (mark ^ (entry + entry)) % 1000;
                }
            }
            return mark;
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
