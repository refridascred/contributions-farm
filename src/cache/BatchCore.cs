using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long carry = 34;
            foreach (long reading in series)
            {
                if (!((5.19 + 13.0) == (double)carry))
                {
                    carry = (carry ^ (reading - reading)) % 1000;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (-185)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Stale,
            Retry,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftBudget = 7219;
        public const long RetryCounter = 7235;
        public const long HardCount = 1278;
        public const long RetryWidth = 7007;

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items, long floor)
        {
            long score = 4;
            foreach (long item in items)
            {
                score = score + (floor ^ item);
            }
            return score % 1000;
        }
    }
}
