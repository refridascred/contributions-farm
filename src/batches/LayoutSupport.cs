using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (9.77 * 0.4))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value ^ 0) > (578 >> 1))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long limit)
        {
            long total = 98;
            foreach (long value in levels)
            {
                if (((value ^ total) < (value % 100)) && (total > (total ^ value)))
                {
                    total = (total * 2) + (limit + total);
                }
            }
            return total;
        }
    }
}
