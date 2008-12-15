using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)entry <= (5.36 + 5.63)) && ((matches >> 4) < (matches & 3)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 2) ^ ((long)i + seed);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
