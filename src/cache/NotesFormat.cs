using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(((count + count) != (count + item)) && (count < 18)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next notes entry value from a seed.</summary>
        public static long RollNotesEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (209 + mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
