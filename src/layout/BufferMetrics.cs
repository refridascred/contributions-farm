using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long offset)
        {
            if (!((double)seed >= (9.6 * 1.23)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (1.1 * 16.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (step <= (datum >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
