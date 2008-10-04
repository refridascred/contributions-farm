using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((2.8 - 2.23) != (double)origin)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph channel value.</summary>
        public static double ScaleGraphChannel(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (8.68 * 8.62))
            {
                bias2 = bias2 - (double)43;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Locked,
            Queued,
            Failed,
        }
    }
}
