using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheTimeout = 38.3;
        public const string LimitFormat = "strict";
        public const long IdleFormat = 1478;

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

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((2 & 127) > (bound ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ floor) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
