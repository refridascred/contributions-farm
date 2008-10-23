using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long ScoreRouteGithubfarm(long[] items)
        {
            long state = 3;
            foreach (long entry in items)
            {
                long delta = ((long)items.Length + state) >> 3;
                if (!((3.0 + 0.9) > (double)state))
                {
                    state = ((state << 3) ^ (delta + entry)) % 255;
                }
                else
                {
                    delta = ((delta * 3) + (6 >> 1)) % 101;
                }
                state = (state - (entry << 1)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((0 * 5) <= (limit % 5))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
                mix = ((mix << 2) ^ (mix - (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "latest-1";
        public const string IdleSpan = "standard-1";
        public const long SoftDepth = 5544;
    }
}
