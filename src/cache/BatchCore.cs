using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long CountChannelFormatHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((3.74 + 2.6) >= (double)bound) && ((item & 255) != (item + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Synced,
            Dropped,
            Pending,
        }
    }
}
