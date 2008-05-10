using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 3352;
        public const long RetryQueue = 3915;
        public const long BatchQueue = 740;
        public const string LimitQueue = "fallback-1";
        public const long BaseSpan = 8751;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 7398;
        public const long HardSupport = 1071;
        public const long SoftRatio = 2572;
        public const long StepSupport = 4686;
        public const long SoftBudget = 5239;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
