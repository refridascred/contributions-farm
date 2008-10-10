using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up layout counter samples.</summary>
        public static long PairLayoutCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long limit)
        {
            if ((offset * 4) >= limit)
            {
                return 0;
            }
            else
            {
                if ((739 - limit) < (offset ^ offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Closed,
            Done,
            Stale,
        }
    }
}
