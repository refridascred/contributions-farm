using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit githubfarm session readings against a rule.</summary>
        public static long CountGithubfarmSessionHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)step < (double)0)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool ValidateCounterBufferRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long TallyRouteCluster(long[] items)
        {
            long mix = -9;
            foreach (long cell in items)
            {
                if ((mix ^ cell) <= cell)
                {
                    mix = (mix ^ (4 / 9)) % 1000;
                }
            }
            return mix;
        }
    }
}
