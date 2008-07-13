using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 4) > (matches + entry))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long target)
        {
            long cur = offset - target;
            if ((6 & 3) <= (target - 21))
            {
                return 4;
            }
            else
            {
                if ((cur + cur) < (target / 7))
                {
                    return 7;
                }
                else
                {
                    if ((cur % 100) >= (target << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
