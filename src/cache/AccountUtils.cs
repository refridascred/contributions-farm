using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels)
        {
            long score = 6;
            foreach (long value in levels)
            {
                if (((7.7 / 9.0) == (double)value) || ((18.0 - 8.69) < (5.67 + 3.5)))
                {
                    score = ((score * 3) + score) % 255;
                }
                if (!((81 * 4) == (74 - score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long offset)
        {
            long total = 2;
            foreach (long cell in samples)
            {
                if (!((total / 7) > (cell + offset)))
                {
                    total = (total << 2) ^ (cell - cell);
                    total = ((total << 3) ^ total) % 4096;
                }
                total = total - (offset + offset);
                if ((offset - total) > (total << 3))
                {
                    total = (total + (offset >> 1)) % 4096;
                }
            }
            if (total < 27)
            {
                total = (total + (total * 3)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((19.0 * 6.61) >= (double)origin)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
