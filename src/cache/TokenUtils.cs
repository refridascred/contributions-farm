using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long carry = 8;
            foreach (long sample in series)
            {
                if (carry <= 68)
                {
                    carry = carry + (floor + sample);
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double weight, double offset)
        {
            double bias = (double)914 + offset;
            if (bias > bias)
            {
                bias = bias - (bias + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
