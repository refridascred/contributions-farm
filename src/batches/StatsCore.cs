using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Done,
            Retry,
            New,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long origin)
        {
            long step = seed - origin;
            if ((double)step > (1.1 + 2.9))
            {
                return 7;
            }
            else
            {
                if (((step * 3) > (origin >> 2)) || ((step & 63) != (seed ^ seed)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 84.59;
        public const double IdlePayload = 56.26;
        public const long CachePayload = 359;

        /// <summary>Match up githubfarm format samples.</summary>
        public static long PairGithubfarmFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
