using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first queue farm entry that matches the target.</summary>
        public static long LookupQueueFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy-1";
        public const long BatchSpan = 1338;
        public const string BatchChecks = "strict-1";
        public const string SoftWidth = "primary-1";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Draft,
            Idle,
            Dropped,
        }
    }
}
