using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count filter counter pairs that satisfy a relation.</summary>
        public static long CompareFilterCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long MeasureSchemaBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally + sample) >= sample) || (tally > sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
