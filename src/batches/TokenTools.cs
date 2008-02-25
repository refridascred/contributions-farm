using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = carry ^ (bound / 3);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
