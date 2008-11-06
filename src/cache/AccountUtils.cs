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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)floor > (0.62 + 8.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
