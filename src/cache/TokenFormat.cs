using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "standard-1";
        public const long DefaultProfile = 8524;
        public const string IdleFactor = "stable-1";
        public const long LimitProfile = 4522;
    }
}
