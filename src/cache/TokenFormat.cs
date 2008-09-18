using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long TallyBatchRecordGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= (item * 2))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 9615;
        public const long HardReport = 4718;
        public const string SoftReport = "standard-1";
        public const string RetryReport = "stable";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
