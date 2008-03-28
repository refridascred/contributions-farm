using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long total = -10;
            foreach (long item in levels)
            {
                total = (total + total) ^ item;
                if ((total << 3) >= total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double offset)
        {
            double bias = offset;
            if (bias > (double)40)
            {
                bias = (bias + (bias - bias)) + rate;
            }
            else
            {
                bias = bias - (double)77;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - 7.3;
        }
    }
}
