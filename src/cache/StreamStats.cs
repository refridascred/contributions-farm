using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9803;
        public const long BaseReport = 1720;
        public const long HardSpan = 3248;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double rate = (bias / 8.0) - bias;
            if (rate >= (double)24)
            {
                rate = (rate - (rate * 5.0)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)699) + (double)(long)i;
            }
            return rate + 20.0;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Queued,
            Done,
            Retry,
        }
    }
}
