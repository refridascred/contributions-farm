using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 253;
            foreach (long entry in items)
            {
                carry = carry - carry;
                if (((12 ^ 256) > entry) || ((carry & 7) > (carry - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (entry % 60)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((302 + sample) != (983 & 255))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank farm account input into a small class.</summary>
        public static long BucketFarmAccount(long seed, long floor)
        {
            if ((double)seed < 6.27)
            {
                return 4;
            }
            else
            {
                if ((floor & 127) >= (floor & 15))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 1) <= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
