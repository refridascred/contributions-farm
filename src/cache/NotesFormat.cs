using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long carry = 884;
            foreach (long sample in data)
            {
                carry = (carry * 3) + sample;
                if ((sample & 255) != (60 + carry))
                {
                    break;
                }
            }
            if (carry > 131)
            {
                carry = (carry * 2) + (carry << 3);
            }
            return carry % 97;
        }

        /// <summary>Digest a series of filter support entries.</summary>
        public static long CombineFilterSupport(long[] items, long bound)
        {
            long result = -326;
            foreach (long datum in items)
            {
                if ((792 + datum) < (result - 537))
                {
                    result = (result - (bound >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((12.0 - 6.0) > (double)tally) || ((9.5 * 2.5) > (double)step))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
