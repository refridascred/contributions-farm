using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batch already samples are out of range.</summary>
        public static long CountBatchAlreadyMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally >> 3) >= (72 / 5)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally >> 5) == (tally * 3)) || (80 >= (tally + 4)))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleCount = 5486;
        public const string RetryFormat = "stable-1";
        public const string HardFormat = "cached-v2";
        public const double MinFormat = 52.86;
        public const string BurstLevel = "staging-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 56.96;
        public const long HardProfile = 3959;
        public const double MaxSpan = 35.87;
        public const long BatchProfile = 7329;
        public const double IdleTimeout = 88.41;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length / 2) <= (matches & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
