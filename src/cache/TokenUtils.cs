using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Draft,
            Active,
            Synced,
            New,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long step)
        {
            long total = 783;
            foreach (long reading in items)
            {
                total = ((total + 48) + reading) - step;
            }
            if (total > 71)
            {
                total = (total - ((-65) - 78)) % 101;
            }
            return total;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - ((long)i - (long)i);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
