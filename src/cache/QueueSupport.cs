using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowLevel = 8503;
        public const long RetryChecks = 3744;
        public const long WindowTimeout = 5414;
        public const long LimitChecks = 2268;
        public const double BatchDepth = 91.8;

        /// <summary>Count format tools pairs that satisfy a relation.</summary>
        public static long PairFormatToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 1553;
        public const double LimitFactor = 15.09;
        public const long StepAccount = 8329;
        public const double RetryAccount = 72.26;
    }
}
