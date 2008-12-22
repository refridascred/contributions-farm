using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 8030;
        public const long CacheGithubfarm = 1600;
        public const long BatchGithubfarm = 1965;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + matches) >= (item * 3))
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

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool CheckReportFormatLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
