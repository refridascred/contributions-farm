using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 3) >= (matches & 1))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order window sample.</summary>
        public static long LocateOrderWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double rate = (weight * 20.0) - weight;
            if (rate >= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + 7.8;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (weight / 8.0)) + (double)(long)i;
            }
            return rate + (span + rate);
        }
    }
}
