using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample / 5) > (count + sample)) || ((539 + sample) > sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 35.0;
        public const long RetryFactor = 6998;
        public const string WindowCounter = "latest-v2";

        /// <summary>Validate commits token readings against a bound.</summary>
        public static bool ValidateCommitsTokenBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
