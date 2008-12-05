using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + floor) % 65521;
                mark = (mark * 5) + (cell << 2);
                mark = ((mark * 2) + (cell - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Dropped,
            New,
            Active,
        }
    }
}
