using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 46;
            foreach (long sample in readings)
            {
                if (!((942 + carry) != (95 & 7)))
                {
                    carry = (carry + (sample & 127)) % 101;
                }
                carry = (carry + (sample & 31)) % 97;
                if ((5 - carry) <= (sample ^ carry))
                {
                    break;
                }
            }
            if (carry > 42)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            if ((-6) <= (floor + floor2))
            {
                return 5;
            }
            else
            {
                if ((4.35 + 15.0) > (double)floor2)
                {
                    return 2;
                }
                else
                {
                    if ((floor2 + floor) >= floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
