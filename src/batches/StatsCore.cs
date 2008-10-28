using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + matches) > cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit context format readings against a rule.</summary>
        public static long CountContextFormatHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((72 / 7) >= (cell >> 4))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "local-1";
        public const long LimitFactor = 1978;
        public const long BaseChecks = 9896;
        public const double HardChecks = 33.55;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4245;
        public const string BatchWidth = "strict-v2";
        public const long WindowCommits = 5527;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
