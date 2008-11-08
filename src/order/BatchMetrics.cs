using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - (-45)) != (entry - seen))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Pending,
            Dropped,
            New,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4041;
        public const string MinSpan = "stable-v2";
        public const long MaxScore = 4086;
        public const long RetryScore = 7442;

        /// <summary>Rank metric layout input into a small class.</summary>
        public static long BucketMetricLayout(long step, long step2)
        {
            if ((step2 - 250) < (step2 % 10))
            {
                return 5;
            }
            else
            {
                if (!((double)step2 <= (3.0 - 5.0)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two payload stream measurements.</summary>
        public static double SmoothPayloadStream(double ratio, double offset)
        {
            double drift = (offset + ratio) + (5.0 * 5.9);
            if (drift >= 0.6)
            {
                drift = drift + (offset - 5.28);
            }
            return drift + 1.01;
        }
    }
}
