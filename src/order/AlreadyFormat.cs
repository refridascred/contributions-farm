using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheRatio = 2567;
        public const long DefaultContext = 2129;
        public const string RetryContext = "stable-1";

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 2) ^ result;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryScore = 7285;
        public const long SoftWidth = 4850;
        public const long BaseBudget = 2723;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Ready,
            New,
            Done,
            Dropped,
        }
    }
}
