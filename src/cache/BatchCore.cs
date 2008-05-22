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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long limit)
        {
            if ((99 >> 2) > origin)
            {
                return 5;
            }
            else
            {
                if (limit < (limit + (-634)))
                {
                    return 1;
                }
                else
                {
                    if (((origin >> 3) < origin) || ((limit % 2) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
