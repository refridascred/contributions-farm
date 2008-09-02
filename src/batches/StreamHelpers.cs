using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((cell * 2) == (cell + tally)))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile report readings against a rule.</summary>
        public static long TallyProfileReportHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally <= target)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 4.87;
        public const long MinRatio = 6678;
        public const string MaxFormat = "fallback-v2";
        public const string LimitDepth = "local-1";

        /// <summary>Locate a cache githubfarm reading by value.</summary>
        public static long FindCacheGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
