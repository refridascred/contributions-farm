using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleRecord = "stable";
        public const long StepRecord = 1006;
        public const long CacheRecord = 4962;

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 4961;
        public const double HardProfile = 21.37;
        public const long BatchRatio = 4632;
        public const long MaxProfile = 9082;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Audit schema command readings against a rule.</summary>
        public static long AuditSchemaCommandGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 12) >= entry)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long seed)
        {
            if ((target * 4) == (seed << 2))
            {
                return 5;
            }
            else
            {
                if ((target >> 1) <= (target * 4))
                {
                    return 8;
                }
                else
                {
                    if (5 < (target % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
