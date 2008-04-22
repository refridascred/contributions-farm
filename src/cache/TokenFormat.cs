using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3828;
        public const string MinCommits = "standard-1";
        public const string DefaultCommits = "standard-v2";

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstWidth = 83.38;
        public const long LimitChecks = 1705;
        public const long BatchChecks = 6189;
        public const long RetryChecks = 9014;
        public const long BaseCount = 3013;
    }
}
