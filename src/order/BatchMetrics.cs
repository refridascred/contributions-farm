using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double bias = floor - gain;
            if (bias <= (double)93)
            {
                bias = bias - (bias - 4.61);
            }
            else
            {
                bias = bias - (floor - bias);
            }
            return bias + (floor - floor);
        }

        /// <summary>Count account counter pairs that satisfy a relation.</summary>
        public static long PairAccountCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "standard-edge";
        public const string HardSpan = "alpha-edge";
        public const long LimitSize = 7483;

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (double)(long)i) - bias;
            }
            return bias2 + (double)119;
        }
    }
}
