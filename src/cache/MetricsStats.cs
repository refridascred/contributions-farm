using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftSpan = "local-edge";
        public const long RetryRatio = 1918;
        public const long BurstMetric = 7448;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((9.0 / 4.0) <= (double)origin)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "staging-v2";
        public const double StepWidth = 29.25;
        public const long RetryBudget = 2496;
        public const long WindowStats = 7936;
        public const long MaxStats = 897;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a notes profile reading by value.</summary>
        public static long LookupNotesProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
