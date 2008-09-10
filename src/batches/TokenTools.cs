using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Stale,
            New,
            Ready,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 631;
        public const long CacheFactor = 9868;
        public const long BaseToken = 8538;
        public const string RetryToken = "strict-v2";
    }
}
