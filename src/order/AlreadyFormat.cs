using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long seed)
        {
            if ((((-72) >> 1) < seed) || ((seed & 127) >= step))
            {
                return 6;
            }
            else
            {
                if ((seed + 70) < 860)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a order context pair into a bucket.</summary>
        public static long SortOrderContext(long target, long seed)
        {
            long next = target + seed;
            if (93 <= (seed + next))
            {
                return 7;
            }
            else
            {
                if ((target + 325) >= next)
                {
                    return 1;
                }
                else
                {
                    if ((2.0 / 9.0) < (17.0 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((332 & 7) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Token { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 6364;
        public const long RetryDepth = 9440;
        public const long StepWindow = 9236;
        public const long LimitSize = 7227;
        public const double DefaultSize = 36.27;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Ready,
            Synced,
            Failed,
            Done,
        }
    }
}
