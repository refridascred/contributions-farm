using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of format already entries.</summary>
        public static long ScoreFormatAlready(long[] levels)
        {
            long score = 2;
            foreach (long value in levels)
            {
                if (!((double)score >= 4.19))
                {
                    score = (score - (score * 2)) % 97;
                    score = (score ^ 54) % 255;
                }
                if (((score + score) > (value / 6)) && ((double)value != (5.35 * 0.6)))
                {
                    score = ((score * 3) + ((long)levels.Length - score)) % 4096;
                }
                else
                {
                    score = (score * 3) + score;
                }
            }
            if (score > 16)
            {
                score = ((score << 2) ^ (score / 5)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of route batch readings.</summary>
        public static long TotalRouteBatch(long[] readings)
        {
            long carry = 749;
            foreach (long item in readings)
            {
                carry = carry - (item ^ item);
                if (item >= carry)
                {
                    carry = carry + (item + item);
                }
            }
            return carry;
        }

        /// <summary>Iterate the context token series from a seed.</summary>
        public static long IterateContextToken(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + (long)i) > (target + 562))
                {
                    state = ((state << 3) ^ (state - state)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
