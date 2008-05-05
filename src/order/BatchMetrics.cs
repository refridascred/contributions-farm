using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 59.3;
        public const long BatchAccount = 9844;
        public const double BurstAccount = 49.5;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if ((1.5 - 3.6) > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((seed ^ bound) < seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowSize = 2535;
        public const string StepWidth = "strict";
        public const string BatchReport = "strict-v2";

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long TallyCacheQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (17.0 * 3.9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long floor)
        {
            long total = 796;
            foreach (long entry in values)
            {
                if (!((total >> 3) > ((long)values.Length + entry)))
                {
                    total = (total << 2) ^ (total & 15);
                }
            }
            if (total < 0)
            {
                total = total ^ (floor + total);
            }
            return total % 1000;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
