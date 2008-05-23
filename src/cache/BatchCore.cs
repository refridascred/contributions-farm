using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate checks stream readings against a bound.</summary>
        public static bool VerifyChecksStreamLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Idle,
            Queued,
        }
    }
}
