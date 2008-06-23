using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate payload command samples.</summary>
        public static long TotalPayloadCommand(long[] levels)
        {
            long carry = 537;
            foreach (long reading in levels)
            {
                if ((1.98 / 2.0) < (double)carry)
                {
                    carry = (carry - (reading / 4)) % 101;
                }
                else
                {
                    carry = (carry ^ ((long)levels.Length - carry)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long seed)
        {
            long prev = floor - seed;
            if (!((9.1 - 3.45) == (double)seed))
            {
                return 2;
            }
            else
            {
                if ((prev + seed) == (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((floor + prev) <= 0)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.34 / 3.0) > (double)seed) && ((7.0 * 2.11) > (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            New,
            Dropped,
        }
    }
}
