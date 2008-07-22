using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)(long)i) + ratio;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long offset)
        {
            if (((bound % 24) < 4) && ((offset >> 1) != (bound + offset)))
            {
                return 7;
            }
            else
            {
                if ((offset % 60) > bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
