using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 7676;
        public const long BaseScore = 715;
        public const double SoftInterval = 32.95;
        public const long BaseTimeout = 1645;
        public const long MaxWidth = 6471;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((seed >> 5) < seed) && ((hits * 2) >= (4 + hits)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools order value from a seed.</summary>
        public static long SeriesToolsOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + (bound + bound)) % 255;
                if ((-964) < (mix + mix))
                {
                    mix = (mix * 4) + bound;
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix * 3) + (mix * 3);
                }
                mix = (mix + (mix << 2)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] values, long seed)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if ((state & 7) >= seed)
                {
                    state = (state << 2) ^ ((-598) ^ 632);
                }
                if (((seed % 97) >= (3 % 7)) && ((datum - datum) <= (datum - state)))
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = ((state * 2) + (state % 3)) % 101;
            }
            return state;
        }
    }
}
