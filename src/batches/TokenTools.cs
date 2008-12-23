using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Locked,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleSpan = 78.26;
        public const long LimitCount = 3966;
        public const long RetryFormat = 5517;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
