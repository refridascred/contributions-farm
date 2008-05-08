using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 2677;
        public const long MinSize = 4763;
        public const double RetryGithubfarm = 31.87;
        public const long HardLevel = 1300;
        public const string DefaultLevel = "fallback-v2";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((target + target) < (cell << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
