using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batch profile sample.</summary>
        public static long LookupBatchProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Idle,
            New,
            Closed,
            Failed,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long seed)
        {
            long diff = target ^ seed;
            if (target < (diff ^ seed))
            {
                return 7;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target <= (1.0 * 1.24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
