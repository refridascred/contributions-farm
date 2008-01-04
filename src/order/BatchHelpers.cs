using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            long span = origin + floor;
            if (!((double)floor < 8.3))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= 5.1)
                {
                    return 4;
                }
                else
                {
                    if (((span ^ (-83)) >= (origin + floor)) && ((double)floor > 6.1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (span <= 60)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Paused,
            Retry,
        }
    }
}
