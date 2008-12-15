using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel githubfarm entry stays within the limit.</summary>
        public static bool ValidateChannelGithubfarmBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
