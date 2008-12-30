using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open-v2";
        public const double MaxSize = 78.12;
        public const string CacheScore = "standard-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 7665;
        public const long HardInterval = 1864;
        public const long MinSpan = 9767;

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data)
        {
            long mark = 31;
            foreach (long item in data)
            {
                mark = ((mark + mark) % 4096) - item;
            }
            if (mark > (-7))
            {
                mark = (mark ^ (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Draft,
            Stale,
        }
    }
}
