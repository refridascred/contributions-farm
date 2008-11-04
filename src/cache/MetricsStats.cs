using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "primary";
        public const long DefaultTools = 7757;
        public const string BurstWidth = "local";
        public const long BurstTools = 5461;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                if (!((12 / 6) == (anchor % 8)))
                {
                    anchor = ((anchor << 2) ^ reading) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - hits) > (2 - hits))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5869;
        public const double BatchSession = 81.43;
        public const long RetrySession = 8469;
    }
}
