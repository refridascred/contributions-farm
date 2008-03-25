using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            long edge = target - target2;
            if (61 > (target + edge))
            {
                return 8;
            }
            else
            {
                if ((target2 + target) > (target2 - edge))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 5) < edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.97 - 20.0) < (double)edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
