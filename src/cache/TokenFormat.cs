using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long mix = -69;
            foreach (long cell in samples)
            {
                mix = ((mix - step) % 1000) + cell;
            }
            return mix;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if ((17.0 - 7.73) > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((bound - floor) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (bound >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound == (double)8)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings)
        {
            long carry = 831;
            foreach (long reading in readings)
            {
                carry = (carry - (carry + reading)) % 4096;
                if (!((carry & 7) != ((long)readings.Length + carry)))
                {
                    carry = (carry ^ carry) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ (reading ^ carry);
                }
            }
            return carry;
        }
    }
}
