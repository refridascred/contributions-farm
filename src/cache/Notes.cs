using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((2 << 2) <= (floor & 3)) || ((double)floor < (8.0 + 5.0))) || ((cell + (-4)) < cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (194 - 9))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
