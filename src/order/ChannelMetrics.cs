using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long GradeChecksBatches(long offset, long seed)
        {
            long delta = offset ^ seed;
            if (((delta % 7) != (seed - 103)) || (3 < (seed + offset)))
            {
                return 6;
            }
            else
            {
                if (((delta >> 1) < (delta + seed)) && (offset < (delta - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + offset) <= delta)
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

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Failed,
            Dropped,
            Idle,
        }
    }
}
