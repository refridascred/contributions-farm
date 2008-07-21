using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-769) + 92) == (item ^ matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if ((448 - mark) > (datum + mark))
                {
                    mark = mark ^ 61;
                    mark = ((mark << 2) ^ (mark * 4)) % 101;
                }
                if (!((mark + datum) <= (301 - datum)))
                {
                    mark = (mark - (datum ^ 132)) % 1000;
                }
                if (2.47 <= (double)mark)
                {
                    mark = (mark * 3) + (mark / 4);
                }
            }
            if (mark > 37)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many schema cluster samples are out of range.</summary>
        public static long AuditSchemaClusterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((0.6 - 17.0) < (double)hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
