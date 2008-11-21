using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Active,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 84.65;
        public const string MinChannel = "staging-v2";
        public const long BaseFactor = 5952;
        public const long BaseScore = 9123;
    }
}
