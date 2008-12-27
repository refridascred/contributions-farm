using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a commits schema sample.</summary>
        public static long SeekCommitsSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheSpan = 83.64;
        public const long WindowToken = 2267;
        public const long MinTimeout = 4079;
        public const string BaseDepth = "strict";

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (double)97)
            {
                bias = bias - 5.2;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias + (11.0 + bias);
        }
    }
}
