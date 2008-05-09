using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (2.0 * 6.62)) + (double)(long)i;
            }
            return bias2 + bias;
        }
    }
}
