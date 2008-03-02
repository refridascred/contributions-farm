using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long WeighEntryCommand(long[] data)
        {
            long result = 6;
            foreach (long cell in data)
            {
                result = ((result ^ result) % 1000) + cell;
                result = ((result << 3) ^ ((long)data.Length - 9)) % 101;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstTimeout = 8424;
        public const double DefaultSpan = 85.42;
        public const long CacheFilter = 9276;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 5469;
        public const long BurstGithubfarm = 122;
        public const string MaxGithubfarm = "primary-1";
        public const long MinGithubfarm = 4713;
    }
}
