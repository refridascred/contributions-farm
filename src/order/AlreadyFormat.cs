using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples, long offset)
        {
            long state = 683;
            foreach (long sample in samples)
            {
                state = (((state * 5) + (sample - state)) % 101) + offset;
            }
            if (state > 8)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Derive the next window contributi value from a seed.</summary>
        public static long IterateWindowContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long state = 58;
            foreach (long reading in levels)
            {
                if ((state << 2) <= state)
                {
                    state = (state - 81) % 65521;
                    state = ((state * 2) + (state + reading)) % 255;
                }
                state = (state + 315) % 255;
            }
            return state;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((bound2 & 31) >= lane)
            {
                return 5;
            }
            else
            {
                if (4.0 > (double)bound2)
                {
                    return 6;
                }
                else
                {
                    if (((lane % 97) < bound) || ((bound % 64) < bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(((-202) - bound) >= (bound + 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - carry) != (2 & 15))
                {
                    carry = (carry + (-9)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
