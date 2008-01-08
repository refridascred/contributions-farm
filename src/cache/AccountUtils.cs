using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ (long)i) % 255;
                if (((floor >> 1) < (470 / 2)) && ((double)(long)i >= 3.33))
                {
                    score = (score - floor) % 101;
                }
                else
                {
                    score = (score ^ (floor % 24)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long offset)
        {
            long carry = -1;
            foreach (long sample in series)
            {
                if (!(offset > (50 ^ (-72))))
                {
                    carry = ((carry - (offset & 255)) % 101) + sample;
                }
            }
            if (carry > 707)
            {
                carry = (carry - (carry - offset)) % 65521;
            }
            return carry % 97;
        }
    }
}
