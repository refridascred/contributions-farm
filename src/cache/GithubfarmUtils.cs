using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Find the first tools context entry that matches the target.</summary>
        public static long FindToolsContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleRatio = "cached-edge";
        public const string WindowSpan = "stable-v2";
        public const long StepCounter = 2328;
        public const double DefaultSpan = 39.95;

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftDepth = "local-1";
        public const string SoftBatches = "legacy-v2";
        public const long DefaultLevel = 7566;
    }
}
