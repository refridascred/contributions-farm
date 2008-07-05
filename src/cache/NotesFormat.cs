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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
