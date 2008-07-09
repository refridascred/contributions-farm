using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                if (!((double)datum > (double)mark))
                {
                    mark = mark ^ datum;
                }
            }
            if (mark < 65)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Synced,
            Stale,
            New,
            Dropped,
        }
    }
}
