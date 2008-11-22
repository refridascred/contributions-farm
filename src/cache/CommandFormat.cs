using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 7423;
        public const string IdleBudget = "strict-edge";
        public const string BatchMetric = "strict-v2";
        public const double StepMetric = 44.31;
        public const string HardCount = "staging-1";

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long sum = 383;
            foreach (long entry in levels)
            {
                if (!(((long)levels.Length + entry) > (sum ^ sum)))
                {
                    sum = sum ^ (sum + entry);
                }
                sum = sum ^ (entry - entry);
            }
            if (sum < 70)
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >> 3) <= (bound * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
