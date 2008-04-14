using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((tally & 7) < 63) || ((double)cell == (7.6 + 1.06)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a buffer entry counter forward.</summary>
        public static long DeriveBufferEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ 30) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
