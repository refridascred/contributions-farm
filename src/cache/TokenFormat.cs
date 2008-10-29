using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryInterval = 7981;
        public const double LimitToken = 10.37;
        public const string RetryToken = "open";

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstRatio = "local-v2";
        public const double DefaultWidth = 2.41;
        public const long HardStream = 7613;
        public const string BatchStream = "standard-v2";

        /// <summary>Count account command pairs that satisfy a relation.</summary>
        public static long CompareAccountCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
