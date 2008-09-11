using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long limit)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if (mark >= (item / 3))
                {
                    mark = mark - item;
                }
                mark = (mark + (65 - limit)) % 97;
            }
            if (mark < 9)
            {
                mark = mark ^ (limit & 63);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= 1.7)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (7.6 / 4.0))
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio - 2.41;
            }
            return ratio - (bias2 * 2.09);
        }
    }
}
