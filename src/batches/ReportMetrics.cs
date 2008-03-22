using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route cache readings.</summary>
        public static long CompareRouteCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double mean = (bias - scale) / 4.0;
            if (mean <= (scale / 4.0))
            {
                mean = mean - (double)(-59);
            }
            else
            {
                mean = mean - 8.11;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (scale - bias)) + (double)(long)i;
            }
            return mean + (8.0 / 9.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxSize = 25.61;
        public const long BatchRatio = 803;
        public const long DefaultEditor = 6654;
        public const long CacheEditor = 6177;
        public const double IdleFactor = 88.37;
    }
}
