using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "fallback-v2";
        public const long HardChannel = 3327;
        public const double HardCount = 36.68;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardWidth = "standard-edge";
        public const long SoftScore = 9469;
        public const double MinScore = 48.28;
        public const string LimitSupport = "stable-edge";

        /// <summary>Adjust a graph contributi reading.</summary>
        public static double AdjustGraphContributi(double bias, double offset)
        {
            double mean = (6.8 + bias) - bias;
            if (mean >= mean)
            {
                mean = mean + (double)2;
            }
            else
            {
                mean = mean - (offset / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (2.0 * 4.0);
        }
    }
}
