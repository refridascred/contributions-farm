using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((entry >> 4) == (entry - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] items, long floor)
        {
            long state = 426;
            foreach (long datum in items)
            {
                if ((state / 9) >= (5 + floor))
                {
                    state = (((state * 4) + floor) % 1000) + datum;
                }
            }
            return state;
        }
    }
}
