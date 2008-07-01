using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long MeasureGithubfarmLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((double)8 != (double)cell) && ((double)seen != (8.03 * 6.0))) || (cell < (seen + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] items, long bound)
        {
            long acc = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (0.24 / 2.0))
                {
                    acc = ((acc - (6 / 6)) % 97) - bound;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a order report sample.</summary>
        public static long LocateOrderReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
