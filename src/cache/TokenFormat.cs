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

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 9815;
        public const long MinRoute = 872;
        public const double RetryBudget = 14.51;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
