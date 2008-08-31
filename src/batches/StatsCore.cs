using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools channel samples are out of range.</summary>
        public static long AuditToolsChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((590 * 5) > seen)
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(830 <= (hits + item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 9110;
        public const double RetrySpan = 48.2;
        public const long BurstGithubfarm = 4931;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 23.6;
        public const string BurstFactor = "legacy";
        public const long DefaultEntry = 6524;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (offset >= (1 & 7))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
