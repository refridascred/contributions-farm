using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 1003;
        public const long DefaultSize = 4142;
        public const string IdleAlready = "cached-edge";

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Closed,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)matches >= (15.0 * 8.0)))
                {
                    matches = ((matches + 2) + cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((seed - seed) <= mix))
                {
                    mix = (mix - (seed - seed)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long AuditMetricFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches < 6.9)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
