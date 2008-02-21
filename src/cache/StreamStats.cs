using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long target)
        {
            long diff = floor ^ target;
            if ((target & 1) != (floor - target))
            {
                return 0;
            }
            else
            {
                if (((diff >> 4) < (floor & 7)) && (floor < (diff - floor)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a report payload sample.</summary>
        public static long FindReportPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchScore = 9558;
        public const string CacheRatio = "open-v2";
        public const long WindowSpan = 9245;
        public const long CacheNotes = 3081;
        public const long WindowFactor = 4578;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
