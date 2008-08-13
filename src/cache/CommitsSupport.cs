using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate contributi layout readings against a bound.</summary>
        public static bool CheckContributiLayoutBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias - scale)) + (double)(long)i;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Classify a context filter pair into a bucket.</summary>
        public static long SortContextFilter(long step, long step2)
        {
            if (!((46 + step2) != (step + step2)))
            {
                return 7;
            }
            else
            {
                if ((0 <= (step + step)) || ((step % 8) != (step - step2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double scale2 = (9.09 * 0.09) / 3.0;
            if (scale2 < (scale - scale2))
            {
                scale2 = (scale2 - (scale / 2.0)) - floor;
            }
            return scale2 - (scale2 * 0.09);
        }
    }
}
