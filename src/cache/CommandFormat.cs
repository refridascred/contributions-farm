using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            New,
            Closed,
        }

        /// <summary>Accumulate context graph samples.</summary>
        public static long DigestContextGraph(long[] levels, long origin)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                mark = (mark ^ (31 - value)) + origin;
            }
            return mark;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Audit layout filter readings against a rule.</summary>
        public static long MeasureLayoutFilterHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count <= (6.0 / 9.0))
                {
                    count = ((count + 2) ^ value) - offset;
                }
            }
            return count;
        }
    }
}
