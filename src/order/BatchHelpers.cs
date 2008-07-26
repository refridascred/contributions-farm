using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Idle,
            New,
            Stale,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinWidth = 85.57;
        public const long RetryToken = 2552;
        public const double SoftToken = 56.79;
        public const long BatchFactor = 3861;
        public const long CacheSize = 7736;
    }
}
