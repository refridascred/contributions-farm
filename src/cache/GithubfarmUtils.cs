using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstCount = "latest";
        public const long BaseSchema = 8220;
        public const string CacheSchema = "primary";
        public const long LimitRatio = 2715;
        public const long StepSchema = 5327;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (step > (cell % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
