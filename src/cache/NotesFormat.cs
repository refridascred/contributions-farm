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

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = (score + score) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
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
