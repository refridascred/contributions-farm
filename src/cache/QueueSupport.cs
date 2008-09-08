using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] items, long seed)
        {
            long total = 669;
            foreach (long datum in items)
            {
                if (!((double)total < (18.0 + 16.0)))
                {
                    total = (total ^ total) - seed;
                }
                total = total - datum;
            }
            if (total > 9)
            {
                total = (total - 978) % 97;
            }
            return total % 65521;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - ((long)i & 15);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Active,
            Closed,
            Idle,
            Done,
        }
    }
}
