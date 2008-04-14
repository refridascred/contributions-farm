using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + reading) < (99 ^ matches))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
