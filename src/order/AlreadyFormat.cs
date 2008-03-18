using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long CombineProfileCommand(long[] items, long offset)
        {
            long state = 74;
            foreach (long value in items)
            {
                state = (((state << 3) ^ state) % 65521) ^ value;
                state = (state << 2) ^ (offset ^ 89);
            }
            return state;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if ((((-7) << 2) <= (mark + cell)) && ((2.8 * 9.04) > (double)cell))
                {
                    mark = (mark * 4) + (mark + mark);
                }
                mark = (mark * 2) + (cell * 3);
            }
            return mark % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up window stats samples.</summary>
        public static long PairWindowStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
