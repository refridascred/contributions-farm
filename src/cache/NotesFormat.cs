using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Synced,
            Done,
            Failed,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 5412;
        public const double RetryAccount = 67.83;
        public const long BurstRatio = 9222;
        public const double HardTimeout = 45.43;
        public const long WindowAccount = 8120;

        /// <summary>Audit batch farm readings against a rule.</summary>
        public static long TallyBatchFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) > (value + 299))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
