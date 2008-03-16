using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9513;
        public const string StepCount = "primary-v2";
        public const double SoftMetrics = 59.03;
        public const long RetryBudget = 2495;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinLevel = 9500;
        public const string LimitFactor = "latest-1";
        public const long WindowBudget = 2066;
        public const double BaseReport = 34.36;

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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((6.33 + 11.0) == (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

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
