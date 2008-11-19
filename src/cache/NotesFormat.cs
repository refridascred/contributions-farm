using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Ready,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 1856;
        public const double IdleNotes = 8.06;
        public const string MaxBudget = "legacy-v2";
        public const string BurstNotes = "primary-edge";
        public const double RetryRatio = 62.43;
    }
}
