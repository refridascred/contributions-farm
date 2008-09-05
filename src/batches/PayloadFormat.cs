using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 1.7;
        public const double WindowBudget = 32.23;
        public const long DefaultBatch = 4681;
        public const string CacheBatch = "primary-1";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
