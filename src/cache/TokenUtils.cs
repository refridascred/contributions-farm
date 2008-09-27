using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit session context readings against a rule.</summary>
        public static long CountSessionContextMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 2.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ datum) + bound;
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics account readings.</summary>
        public static long CompareMetricsAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
