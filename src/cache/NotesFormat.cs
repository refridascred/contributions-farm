using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the batches checks entries that pass the check.</summary>
        public static long TallyBatchesChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry * 5) != (955 + 10))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.93;
        public const double HardFactor = 31.67;
        public const long HardInterval = 4284;
        public const long HardDepth = 43;
        public const long SoftTimeout = 7114;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
