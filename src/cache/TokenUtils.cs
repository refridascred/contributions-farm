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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item > (9.0 / 5.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
