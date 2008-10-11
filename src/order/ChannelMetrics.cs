using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Paused,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long seed)
        {
            long prev = limit + seed;
            if ((329 <= (prev - seed)) && ((952 + seed) >= limit))
            {
                return 0;
            }
            else
            {
                if ((seed & 1) < 5)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
