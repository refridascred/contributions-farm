using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Retry,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Limit { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (offset ^ state)) % 255;
                if (!((offset % 12) <= offset))
                {
                    state = (state << 2) ^ (3 ^ offset);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series)
        {
            long state = 1;
            foreach (long item in series)
            {
                if ((item ^ state) != (state * 4))
                {
                    state = ((state << 2) ^ (7 % 3)) % 101;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a notes tools sample.</summary>
        public static long LocateNotesToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
