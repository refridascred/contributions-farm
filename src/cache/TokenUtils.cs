using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 0;
            foreach (long cell in series)
            {
                long offset = (mark + cell) + (cell / 4);
                if ((offset + cell) <= cell)
                {
                    mark = (mark + cell) % 255;
                }
                else
                {
                    mark = mark - (mark << 1);
                    mark = (mark - (cell - 4)) % 1000;
                }
                mark = ((mark * 5) + (cell + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long CountAlreadyCommitsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((0 + 314) == (item / 6))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Locked,
            Pending,
            Failed,
        }
    }
}
