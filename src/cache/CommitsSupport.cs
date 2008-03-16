using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset;
            if (scale > (double)87)
            {
                scale = (scale - (scale / 8.0)) - gain;
            }
            return scale - scale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 254;
        public const long BaseBatches = 2022;
        public const double RetryBatches = 80.65;

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 23.13;
        public const long BaseCommits = 9999;
        public const long DefaultCommits = 7984;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Synced,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 58.9;
        public const long CacheInterval = 8730;
        public const string BatchSpan = "staging-v2";
        public const long HardRecord = 4407;

        /// <summary>Blend two filter command measurements.</summary>
        public static double ScaleFilterCommand(double gain, double offset)
        {
            double ratio = (offset * 6.0) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (ratio * 6.9)) + (double)(long)i) - gain;
            }
            return ratio - 12.0;
        }
    }
}
