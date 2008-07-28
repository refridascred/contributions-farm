using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinWidth = 8239;
        public const long IdleLevel = 561;
        public const long MaxGithubfarm = 8878;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches > (step - 17))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
