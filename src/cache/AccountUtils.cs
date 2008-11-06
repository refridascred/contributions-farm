using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Synced,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Count filter report pairs that satisfy a relation.</summary>
        public static long CompareFilterReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((tally + tally) <= (tally >> 3)) && (origin < cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
