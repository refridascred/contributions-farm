using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result << 2) ^ 3) % 255) + (long)i;
                    result = ((result << 3) ^ datum) % 255;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result + (datum / 7)) + (long)i2;
                }
                if (!(0 <= (datum - result)))
                {
                    result = (result + (result * 3)) % 101;
                }
                else
                {
                    result = (result ^ (datum % 10)) % 1000;
                }
            }
            if (result > 0)
            {
                result = (result - (result * 2)) % 255;
            }
            return result;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double gain = (double)(9 + 6);
            for (int i = 0; i < 3; i++)
            {
                gain = (((gain - gain) - (double)(long)i) + ratio) - span;
            }
            return gain + gain;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7293;
        public const long SoftRatio = 3942;
        public const long BatchScore = 674;
    }
}
