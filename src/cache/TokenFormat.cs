using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count stats layout pairs that satisfy a relation.</summary>
        public static long CompareStatsLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (limit >= (limit << 1))
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((787 + datum) >= (hits ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
