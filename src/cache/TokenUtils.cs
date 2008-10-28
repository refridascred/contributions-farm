using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 8218;
        public const string MinCluster = "cached-1";
        public const long RetryCluster = 9039;
        public const long BurstCluster = 5288;
        public const long LimitCluster = 8371;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Retry,
            Draft,
            New,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
