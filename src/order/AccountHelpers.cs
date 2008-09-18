using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Ready,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Derive the next metrics cluster value from a seed.</summary>
        public static long SeriesMetricsCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many metric githubfarm samples are out of range.</summary>
        public static long CountMetricGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen > (seen % 97)) && (6.8 > (double)seen)) || ((seen / 8) >= (2 - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9594;
        public const long SoftTimeout = 1608;
        public const long CacheFactor = 515;
        public const double DefaultSupport = 77.52;
        public const long CacheBudget = 4122;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Active,
            Failed,
            New,
            Paused,
        }
    }
}
