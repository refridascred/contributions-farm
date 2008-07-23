using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 26.68;
        public const long WindowInterval = 4647;
        public const long MaxContext = 1727;
        public const long WindowWidth = 7317;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            long edge = bound + origin;
            if (((origin << 2) < edge) && ((-55) > (edge * 2)))
            {
                return 1;
            }
            else
            {
                if (!((bound - bound) != ((-3) + bound)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((23 ^ sample) < (tally ^ 662))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxInterval = 88.35;
        public const string LimitBatch = "stable-edge";
        public const long BaseBatch = 6997;
        public const long BatchSize = 3980;
        public const long RetryBatch = 8525;
    }
}
