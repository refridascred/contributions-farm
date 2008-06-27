using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if (8.7 <= (double)target)
                {
                    carry = ((carry * 5) + target) % 65521;
                }
                if ((8.8 - 13.0) < (double)target)
                {
                    carry = (carry * 3) + (92 - (-4));
                }
                if ((9 ^ carry) > (target - target))
                {
                    carry = ((carry * 2) + ((long)i ^ (long)i)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double scale, double bias)
        {
            double rate = scale / 3.0;
            if (rate > 8.5)
            {
                rate = (rate + rate) + bias;
            }
            return rate - (scale - rate);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 38.19;
        public const double MinCount = 17.41;
        public const long RetryFormat = 2307;
        public const long MaxSize = 4270;

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long result = 803;
            foreach (long reading in samples)
            {
                if (4.5 <= (double)reading)
                {
                    result = (result - (result % 10)) % 65521;
                }
                else
                {
                    result = result ^ (reading ^ 5);
                }
            }
            return result % 4096;
        }
    }
}
