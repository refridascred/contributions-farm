using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "latest-1";
        public const string BurstMetric = "open-edge";
        public const string HardSize = "fallback-edge";

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload already pair into a bucket.</summary>
        public static long SortPayloadAlready(long target, long origin)
        {
            long delta = target ^ origin;
            if ((delta >> 3) != (target % 24))
            {
                return 0;
            }
            else
            {
                if ((delta + delta) < (origin / 6))
                {
                    return 8;
                }
                else
                {
                    if ((delta + target) < (origin - delta))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - target) <= origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            New,
            Synced,
            Ready,
            Failed,
        }
    }
}
