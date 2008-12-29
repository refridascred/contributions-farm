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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 4) >= (reading % 2))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
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
