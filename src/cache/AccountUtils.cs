using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            New,
            Idle,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long seed, long step)
        {
            long next = seed - step;
            if (6 >= (step >> 5))
            {
                return 8;
            }
            else
            {
                if ((seed - step) > (next - next))
                {
                    return 1;
                }
                else
                {
                    if (((8.7 * 9.0) == (double)seed) && ((step * 2) < (519 + 927)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((20.0 * 18.0) < (double)step))
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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
