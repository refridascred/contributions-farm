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

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstInterval = 55.72;
        public const double IdleStats = 70.49;
        public const long DefaultStats = 3201;
        public const long StepCount = 4197;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Audit editor githubfarm readings against a rule.</summary>
        public static long TallyEditorGithubfarmOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches + offset) < matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
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
