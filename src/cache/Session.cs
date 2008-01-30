using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            long slot = step + target;
            if ((target > (slot << 3)) || ((slot << 2) < (82 + step)))
            {
                return 5;
            }
            else
            {
                if ((slot << 1) != (step + target))
                {
                    return 1;
                }
                else
                {
                    if ((step <= (slot - target)) || (step <= (target & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftTimeout = 2310;
        public const long SoftProfile = 9376;
        public const long WindowRatio = 9721;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (floor > (479 * 2))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
