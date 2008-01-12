using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowFactor = 973;
        public const long SoftMetrics = 6304;
        public const long MaxMetrics = 9612;
        public const string StepInterval = "latest-v2";
        public const double CacheScore = 20.28;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally << 2) <= (cell >> 5)) && (1 >= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the format graph entries that pass the check.</summary>
        public static long AuditFormatGraphGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)hits >= (20.0 - 9.2)))
                {
                    hits = ((hits + 1) - value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Retry,
            Failed,
            New,
            Done,
        }
    }
}
