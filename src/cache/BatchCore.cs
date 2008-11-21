using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long RankStreamAlready(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((bound < (seed - bound)) || (bound >= (bound2 - seed)))
            {
                return 5;
            }
            else
            {
                if (((seed & 7) >= (bound2 / 4)) || ((bound << 2) != (bound + bound2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            New,
            Synced,
            Queued,
        }
    }
}
