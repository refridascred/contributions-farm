using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 602;
            foreach (long sample in levels)
            {
                score = (score - (score + score)) - sample;
            }
            return score;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (12.0 - 8.4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 7;
            foreach (long cell in readings)
            {
                if ((double)total >= (6.5 / 7.0))
                {
                    total = ((total * 2) + 2) % 4096;
                }
                if ((43 << 1) < cell)
                {
                    total = ((total << 2) ^ (cell + 0)) % 97;
                }
                if ((cell - 70) == (total % 10))
                {
                    break;
                }
            }
            return total;
        }
    }
}
