using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "local";
        public const long IdleInterval = 6554;
        public const double DefaultRecord = 49.57;
        public const string LimitRecord = "standard-v2";

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (594 & 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long limit)
        {
            if ((origin << 3) >= (origin ^ origin))
            {
                return 2;
            }
            else
            {
                if ((limit & 127) >= (99 ^ 0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Queued,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
