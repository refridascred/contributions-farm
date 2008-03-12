using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long ScoreStatsContributi(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                if ((double)sum >= (double)item)
                {
                    sum = sum + (item & 31);
                }
            }
            return sum;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Active,
            Ready,
        }
    }
}
