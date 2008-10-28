using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7214;
        public const long SoftCommand = 3690;
        public const string WindowSize = "strict-1";
        public const long CacheCommand = 4755;
        public const string RetryCommand = "strict-edge";

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + 26) > origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
