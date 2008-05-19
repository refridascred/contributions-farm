using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long mix = 4;
            foreach (long entry in values)
            {
                mix = mix + ((long)values.Length - entry);
            }
            if (mix > (-4))
            {
                mix = ((mix * 3) + 3) % 255;
            }
            return mix % 65521;
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
