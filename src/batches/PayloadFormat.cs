using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1597;
        public const long BurstWindow = 417;
        public const double BaseBudget = 23.0;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long TotalBufferCache(long[] data)
        {
            long result = 158;
            foreach (long item in data)
            {
                result = (result ^ (result - result)) % 65521;
                if ((result * 5) <= result)
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (item & 63)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double scale2 = (double)(4 - 120);
            if (scale2 >= (double)11)
            {
                scale2 = ((scale2 + (double)859) - scale) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + 6.4) - (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
