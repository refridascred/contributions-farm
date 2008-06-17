using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 97.71;
        public const long StepMetric = 3463;
        public const long BatchMetric = 2376;
        public const long SoftTimeout = 7956;
        public const long MinMetric = 2322;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long bound)
        {
            long bound2 = target - bound;
            if ((605 / 9) >= (bound - bound2))
            {
                return 2;
            }
            else
            {
                if ((bound2 << 3) < 685)
                {
                    return 5;
                }
                else
                {
                    if (((bound2 ^ bound) > bound2) && ((target >> 2) > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
