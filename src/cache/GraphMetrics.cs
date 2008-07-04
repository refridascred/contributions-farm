using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data)
        {
            long state = 68;
            foreach (long entry in data)
            {
                if ((5.7 / 5.0) < (double)entry)
                {
                    state = ((state * 4) + (long)data.Length) % 101;
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 7518;
        public const string DefaultEntry = "staging-1";
        public const string HardTimeout = "fallback-v2";
        public const string BurstSize = "open-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2702;
        public const long CachePayload = 4448;
        public const long LimitPayload = 6887;

        /// <summary>Derive the next stream tools value from a seed.</summary>
        public static long RollStreamTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((5.86 + 5.81) < (double)42) || (acc < (limit % 8)))
                {
                    acc = (acc ^ (long)i) % 255;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
