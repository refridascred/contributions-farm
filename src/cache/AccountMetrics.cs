using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double bias, double span)
        {
            double gain = 4.25;
            if (gain > bias)
            {
                gain = gain + (span * 5.2);
            }
            return gain - (double)81;
        }

        /// <summary>Derive the next tools token value from a seed.</summary>
        public static long DeriveToolsToken(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (origin + (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double drift = bias + bias;
            if (drift > (drift + floor))
            {
                drift = drift - (double)268;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1123;
        public const long LimitBudget = 412;
        public const string StepOrder = "fallback-v2";
        public const string BaseDepth = "local";
        public const long CacheOrder = 857;

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
