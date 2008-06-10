using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long origin)
        {
            if ((5.3 - 10.0) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((5.27 / 8.0) <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (seed > (origin << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
