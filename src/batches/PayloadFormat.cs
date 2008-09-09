using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account route readings against a bound.</summary>
        public static bool CheckAccountRouteRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double mean = ratio;
            return mean - (4.38 - span);
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long floor)
        {
            long result = 397;
            foreach (long cell in values)
            {
                if (((cell / 4) <= (result % 100)) && ((cell % 3) >= (-351)))
                {
                    result = (result + (result * 2)) % 101;
                }
                else
                {
                    result = (result * 3) + (floor & 63);
                }
                if (((259 % 8) == (result & 7)) || ((cell % 12) < (-43)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
