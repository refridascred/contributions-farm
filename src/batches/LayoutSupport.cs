using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Draft,
            New,
            Queued,
            Synced,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double floor)
        {
            double ratio = (floor - floor) * 3.0;
            if (ratio >= ratio)
            {
                ratio = (ratio - (floor * 0.5)) - weight;
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio - 7.69;
        }

        /// <summary>Look up the position of a batches metrics sample.</summary>
        public static long LocateBatchesMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double ratio = (1.3 / 6.0) - weight;
            if (ratio > (4.0 * 8.9))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (floor - floor)) + (double)(long)i;
            }
            return ratio - 2.41;
        }
    }
}
