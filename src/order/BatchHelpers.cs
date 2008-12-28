using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally / 9) <= (4 + tally))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSize = 3635;
        public const long CacheAlready = 530;
        public const string MinInterval = "open";
        public const string MaxScore = "strict-edge";

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Active,
            Dropped,
        }
    }
}
