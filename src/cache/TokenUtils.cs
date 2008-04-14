using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBudget = 854;
        public const long SoftWidth = 166;
        public const long BaseBatches = 8521;
        public const string StepScore = "strict-v2";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings, long seed)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = (sum + seed) - sample;
            }
            if (sum > (-8))
            {
                sum = (sum * 4) + (sum & 1);
            }
            return sum;
        }
    }
}
