using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 3473;
        public const long StepInterval = 3624;
        public const long StepCount = 9484;
        public const long CacheLevel = 3812;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
