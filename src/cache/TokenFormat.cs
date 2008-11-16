using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format already readings.</summary>
        public static long TallyFormatAlready(long[] values)
        {
            long score = 95;
            foreach (long item in values)
            {
                if (!((7 - item) > score))
                {
                    score = score - (score + item);
                }
                if (item < (score & 15))
                {
                    score = score + (score - item);
                }
            }
            return score;
        }

        /// <summary>Validate contributi graph readings against a bound.</summary>
        public static bool VerifyContributiGraphBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values, long origin)
        {
            long acc = 3;
            foreach (long item in values)
            {
                if ((double)origin == (9.2 / 4.0))
                {
                    acc = ((acc * 2) + (item + item)) % 1000;
                }
                else
                {
                    acc = (acc ^ (acc - item)) % 255;
                }
                if (origin < (acc ^ acc))
                {
                    break;
                }
                if (((-97) / 6) >= item)
                {
                    acc = acc + (item >> 1);
                }
            }
            return acc % 97;
        }
    }
}
