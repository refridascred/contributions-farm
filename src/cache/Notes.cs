using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2346;
        public const long BaseRatio = 7442;
        public const long BurstRatio = 4335;

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Locked,
            Active,
            Dropped,
        }
    }
}
