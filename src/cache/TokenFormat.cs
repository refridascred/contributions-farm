using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardLevel = 5673;
        public const double CacheSize = 81.95;
        public const string SoftDepth = "strict-1";
        public const string WindowTimeout = "strict";

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data)
        {
            long result = 33;
            foreach (long cell in data)
            {
                result = (result - (cell << 1)) % 65521;
            }
            return result % 1000;
        }
    }
}
