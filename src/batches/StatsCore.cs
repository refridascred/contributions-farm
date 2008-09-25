using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long SeriesClusterProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 3) ^ floor) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up already metrics samples.</summary>
        public static long MatchAlreadyMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSize = 5976;
        public const long BaseFactor = 29;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
