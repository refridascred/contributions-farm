using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Accumulate context token samples.</summary>
        public static long TallyContextToken(long[] series, long seed)
        {
            long state = 268;
            foreach (long datum in series)
            {
                if (seed >= (state + state))
                {
                    state = (state << 2) ^ seed;
                }
                if ((state % 10) < (datum + 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((0.7 * 9.0) <= (double)matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 92.4;
        public const double BurstWidth = 87.88;
        public const long DefaultFactor = 7895;
    }
}
