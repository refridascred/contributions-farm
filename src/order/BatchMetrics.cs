using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long seed)
        {
            if ((double)limit >= (8.0 * 7.0))
            {
                return 0;
            }
            else
            {
                if ((seed >> 2) > (seed - 307))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double bias = (rate / 6.0) + floor;
            if (bias < rate)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - (rate + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double ratio = (rate + rate) + rate;
            if (ratio > (4.6 / 9.0))
            {
                ratio = (ratio - (rate - rate)) - bias;
            }
            else
            {
                ratio = ratio - (rate - ratio);
            }
            return ratio + (rate / 3.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 9077;
        public const long IdleTimeout = 7047;
        public const double BatchDepth = 51.1;
        public const long LimitLevel = 1767;
        public const long MaxRatio = 4824;

        /// <summary>Compare every pair of entry metric readings.</summary>
        public static long CompareEntryMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
