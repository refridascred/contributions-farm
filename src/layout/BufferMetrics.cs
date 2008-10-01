using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the booking state values.</summary>
        public enum BookingState
        {
            Dropped,
            Active,
            Closed,
            Paused,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long origin)
        {
            if ((3 & 127) == (2 - origin))
            {
                return 1;
            }
            else
            {
                if (origin < (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if (!((step - origin) >= (origin ^ (-9))))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank order layout input into a small class.</summary>
        public static long RankOrderLayout(long floor, long target)
        {
            if (((23 & 15) != (target + 612)) || ((floor * 3) <= (floor + target)))
            {
                return 5;
            }
            else
            {
                if ((16.0 * 15.0) == (double)target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
