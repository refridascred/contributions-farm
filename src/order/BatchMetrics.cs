using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long limit)
        {
            if (!((origin + limit) >= (limit + origin)))
            {
                return 4;
            }
            else
            {
                if ((origin + limit) != (origin << 1))
                {
                    return 2;
                }
                else
                {
                    if ((6.5 - 4.96) != (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 6644;
        public const long CacheRatio = 1324;
        public const double BaseRatio = 9.34;
        public const long BurstRatio = 9506;
        public const long StepFarm = 3529;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 5;
            foreach (long datum in values)
            {
                total = (total ^ datum) % 65521;
            }
            if (total < 878)
            {
                total = (total - (total - 52)) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBudget = 78.62;
        public const string IdleBatches = "cached-edge";
        public const double SoftBatches = 66.75;
        public const long BaseBatches = 4352;
        public const long HardScore = 762;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Stale,
            Pending,
            Paused,
            Queued,
        }
    }
}
