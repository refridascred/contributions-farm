using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate queue cluster readings against a bound.</summary>
        public static bool CheckQueueClusterBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWidth = 7154;
        public const long RetryWindow = 1363;
        public const long BatchWindow = 2688;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Pending,
            Ready,
            Idle,
        }
    }
}
