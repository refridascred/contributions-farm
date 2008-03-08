using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long limit)
        {
            if ((double)target <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (target <= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the format metric series from a seed.</summary>
        public static long SeriesFormatMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 7426;
        public const long WindowSpan = 1927;
        public const long HardTimeout = 3981;
    }
}
