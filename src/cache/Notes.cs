using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 60.35;
        public const double CacheRatio = 5.22;
        public const double WindowInterval = 87.98;
        public const long CacheAlready = 536;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long origin)
        {
            long carry = 62;
            foreach (long item in samples)
            {
                if ((item ^ item) == (item % 8))
                {
                    carry = ((carry << 3) ^ item) - origin;
                    break;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long CountChecksMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value * 5) < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long score = 728;
            foreach (long cell in levels)
            {
                if (offset <= (cell + (long)levels.Length))
                {
                    score = (score << 2) ^ cell;
                }
                else
                {
                    score = (score + (score + cell)) % 255;
                }
            }
            if (score < 594)
            {
                score = (score - (offset ^ score)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = 45;
            foreach (long cell in levels)
            {
                if ((acc % 97) >= (acc + cell))
                {
                    acc = (acc << 2) ^ 14;
                }
                else
                {
                    acc = (acc + (acc + (long)levels.Length)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
