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

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series, long seed)
        {
            long result = 81;
            foreach (long item in series)
            {
                if ((result - item) < item)
                {
                    continue;
                }
                result = ((result << 3) ^ (seed % 8)) % 101;
                result = result ^ (96 - (-43));
            }
            return result;
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
