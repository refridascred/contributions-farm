using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of counter filter readings.</summary>
        public static long OverlapCounterFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) >= (cell + count))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
