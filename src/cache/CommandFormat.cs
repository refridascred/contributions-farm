using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Pending,
            Done,
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long CountEntrySchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (item + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
