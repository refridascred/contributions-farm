using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long bound)
        {
            long score = 17;
            foreach (long cell in levels)
            {
                if ((93 - cell) <= (cell >> 5))
                {
                    score = (score + (bound + cell)) % 101;
                }
            }
            if (score > 898)
            {
                score = (score ^ (score / 3)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1052;
        public const long IdleWidth = 1301;
        public const double IdleInterval = 63.17;
        public const long BurstCommand = 5374;
        public const long DefaultLevel = 73;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
