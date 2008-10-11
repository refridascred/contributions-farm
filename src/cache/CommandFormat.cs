using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate2 + bias))
            {
                rate2 = (rate2 + (double)0) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 + (double)(-9);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) >= (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6300;
        public const long DefaultPayload = 4800;
        public const long SoftPayload = 9916;
        public const string BaseDepth = "cached-v2";
        public const long HardScore = 1288;
    }
}
