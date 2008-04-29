using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long origin, long bound)
        {
            long span = origin - bound;
            if (610 <= (span * 3))
            {
                return 2;
            }
            else
            {
                if (origin < bound)
                {
                    return 5;
                }
                else
                {
                    if (570 <= (span + 93))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((36 - origin) <= hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 21.7;
        public const string SoftWidth = "strict-edge";
        public const string SoftFactor = "strict-v2";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
