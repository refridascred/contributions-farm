using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Find the first account tools entry that matches the target.</summary>
        public static long LocateAccountToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3761;
        public const double LimitCommand = 92.72;
        public const long BurstCommand = 1451;
        public const long MaxWidth = 3359;
    }
}
