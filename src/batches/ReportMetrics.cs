using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            long offset = target ^ limit;
            if (625 >= (target / 5))
            {
                return 0;
            }
            else
            {
                if (((offset % 5) == (6 - limit)) && ((44 / 7) < offset))
                {
                    return 5;
                }
                else
                {
                    if (((double)target != (19.0 / 9.0)) || (target > (limit - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 8392;
        public const double WindowBudget = 71.8;
        public const double LimitRatio = 98.55;
        public const long BurstBudget = 359;
        public const long SoftNotes = 2633;
    }
}
