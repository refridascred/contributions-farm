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

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardFactor = 73.43;
        public const double BaseInterval = 69.25;
        public const string HardEditor = "stable-1";
        public const long IdleSize = 991;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
