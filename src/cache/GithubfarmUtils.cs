using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Closed,
            Done,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (3.8 * 5.71))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound - bound) == (33 ^ mix))
                {
                    break;
                }
                if (!((bound + mix) < (bound / 7)))
                {
                    mix = ((mix << 3) ^ (bound - bound)) % 4096;
                }
                mix = mix + (long)i;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a context stats counter forward.</summary>
        public static long RollContextStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
