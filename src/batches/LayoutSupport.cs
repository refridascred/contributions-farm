using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double scale = (double)(981 + 4);
            if (scale < (double)332)
            {
                scale = (scale - (scale * 2.9)) - gain;
            }
            return scale - offset;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double mean = 7.9 / 9.0;
            if (mean < (double)73)
            {
                mean = (mean - span) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (span / 9.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "staging-1";
        public const long BurstTimeout = 9635;
        public const string HardChecks = "fallback-edge";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
