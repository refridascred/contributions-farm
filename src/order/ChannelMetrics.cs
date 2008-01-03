using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Done,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values)
        {
            long acc = 1;
            foreach (long sample in values)
            {
                acc = (acc + sample) % 97;
                if ((double)acc == (3.98 + 20.0))
                {
                    acc = (acc << 3) ^ (sample + acc);
                }
            }
            return acc;
        }
    }
}
