using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (bound - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Done,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long target)
        {
            long acc = 324;
            foreach (long value in values)
            {
                if ((54 < (acc / 5)) || ((1 & 127) < (target >> 1)))
                {
                    acc = ((acc ^ (1 << 3)) % 101) - value;
                }
                acc = acc ^ (acc * 3);
            }
            return acc;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Failed,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 15.65;
        public const long MaxPayload = 5963;
        public const long SoftCount = 607;
    }
}
