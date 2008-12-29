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

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items, long origin)
        {
            long anchor = 737;
            foreach (long entry in items)
            {
                if (((entry & 15) > (entry ^ 7)) && ((2.0 * 5.7) == (double)entry))
                {
                    anchor = anchor + (anchor * 4);
                }
                anchor = ((anchor << 3) ^ origin) % 4096;
            }
            return anchor;
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
