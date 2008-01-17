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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((510 >> 2) != (value + 12))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
