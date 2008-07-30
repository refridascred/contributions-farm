using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value & 127) < (value - limit))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "primary-v2";
        public const long MaxSession = 5406;
        public const long SoftTimeout = 9866;

        /// <summary>Validate tools filter readings against a bound.</summary>
        public static bool ValidateToolsFilterLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
