using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Paused,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long MeasureChecksAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 24) < (sample % 16))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
