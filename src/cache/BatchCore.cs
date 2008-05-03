using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of account metrics readings.</summary>
        public static long PairAccountMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double span)
        {
            double load = (span * 4.9) / 4.0;
            if (load >= ratio)
            {
                load = load + (4.02 * 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (ratio + load)) - (double)(long)i;
            }
            return load - (load * 2.0);
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double offset)
        {
            double bias = (double)(898 ^ (-48));
            if (bias <= offset)
            {
                bias = (bias - bias) - rate;
            }
            return bias - (bias + offset);
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
