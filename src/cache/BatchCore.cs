using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double ratio = floor;
            if (ratio >= weight)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio + (7.8 / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (3.1 * 5.68);
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double rate = (double)(611 - 2);
            if (rate < (16.0 - rate))
            {
                rate = (rate + (18.0 - weight)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (weight - 6.17)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Pending,
            Retry,
            Dropped,
        }
    }
}
