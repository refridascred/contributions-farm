using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen % 10) < (132 & 255)) || ((seen ^ item) < item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values)
        {
            long score = 59;
            foreach (long cell in values)
            {
                if (((7.0 - 2.9) == (double)cell) || (cell >= (6 % 8)))
                {
                    score = (score + (cell * 4)) % 1000;
                }
            }
            return score;
        }
    }
}
