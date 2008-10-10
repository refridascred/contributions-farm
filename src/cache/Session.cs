using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long target)
        {
            long prev = bound - target;
            if (prev < (bound * 5))
            {
                return 6;
            }
            else
            {
                if (!((prev >> 5) >= (target ^ 90)))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound == (3.59 + 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)bound <= (4.2 * 4.3)) && ((prev - prev) < (prev / 9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseTimeout = 5629;
        public const double StepStream = 72.35;
        public const double CacheStream = 36.28;
    }
}
