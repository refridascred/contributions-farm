using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen >> 3) >= (value + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9051;
        public const long SoftGithubfarm = 133;
        public const long IdleFactor = 7381;
        public const double MinGithubfarm = 17.83;
    }
}
