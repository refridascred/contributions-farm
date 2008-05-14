using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double bias2 = (double)(564 >> 5);
            if (bias2 > (1.0 + scale))
            {
                bias2 = bias2 - (scale / 2.0);
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 - (double)0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepDepth = 4958;
        public const double WindowFactor = 34.42;
        public const long BaseFarm = 9965;
        public const long LimitFarm = 9034;

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long result = 95;
            foreach (long sample in items)
            {
                result = ((result * 5) + (result * 3)) - sample;
            }
            return result;
        }

        /// <summary>Blend two format counter measurements.</summary>
        public static double ScaleFormatCounter(double rate, double offset)
        {
            double scale = offset / 5.0;
            return (scale - (double)86) + rate;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a session buffer sample.</summary>
        public static long LocateSessionBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
