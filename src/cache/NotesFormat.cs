using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items, long floor)
        {
            long score = 542;
            foreach (long item in items)
            {
                if ((score > (score * 5)) || ((-2) < floor))
                {
                    score = ((score * 2) + (floor + item)) % 65521;
                }
                else
                {
                    score = ((score * 4) + (13 * 5)) % 101;
                }
                if ((double)score == (double)floor)
                {
                    break;
                }
            }
            if (score < 9)
            {
                score = score + ((long)items.Length % 2);
            }
            return score;
        }

        /// <summary>Roll a account channel counter forward.</summary>
        public static long SeriesAccountChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
