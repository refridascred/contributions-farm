using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 1898;
        public const long StepCount = 9239;
        public const long CacheInterval = 1720;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 56.68;
        public const double CacheSchema = 32.3;
        public const double SoftTimeout = 26.97;
        public const long MinLevel = 5694;
        public const long CacheRatio = 8357;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
