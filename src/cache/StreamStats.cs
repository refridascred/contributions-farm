using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a batch token value against two limits.</summary>
        public static long GradeBatchToken(long offset, long seed)
        {
            if ((double)seed <= (12.0 * 7.5))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) > (offset >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (4.8 - 9.99))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed > (6.2 - 14.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 7918;
        public const string WindowDepth = "standard-1";
        public const long SoftSupport = 2069;
        public const string LimitSize = "open";
    }
}
