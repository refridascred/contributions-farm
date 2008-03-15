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

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Ready,
            Done,
            Retry,
        }

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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((6.0 + 1.8) >= (double)value) || ((matches + 74) != (matches + matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next schema filter value.</summary>
        public static double SmoothSchemaFilter(double gain, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (double)0) - (double)(long)i) - gain;
            }
            return ratio - (double)348;
        }
    }
}
