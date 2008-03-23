using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long seed, long target)
        {
            if ((double)seed < (4.43 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((double)target != (7.63 - 2.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Queued,
            Paused,
            Ready,
            Pending,
        }
    }
}
