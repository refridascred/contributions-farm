using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 8454;
        public const string RetrySpan = "latest-edge";
        public const long HardGraph = 5992;
        public const long LimitTimeout = 654;
        public const double MinWidth = 37.56;

        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long BucketAlreadyNotes(long offset, long target)
        {
            long slot = offset - target;
            if (((double)slot <= (0.9 / 7.0)) && ((double)99 < (double)target))
            {
                return 1;
            }
            else
            {
                if ((offset / 4) >= (slot >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((5 ^ target) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
