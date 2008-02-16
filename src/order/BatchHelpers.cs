using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Pending,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Grade a batch context value against two limits.</summary>
        public static long SortBatchContext(long target, long origin)
        {
            if ((double)origin >= (double)target)
            {
                return 1;
            }
            else
            {
                if (!((target << 3) >= 4))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 5899;
        public const long LimitRatio = 3325;
        public const string IdleCommand = "open-v2";
        public const double HardCommand = 27.39;
        public const double CacheSize = 8.06;
    }
}
