using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if (floor <= (800 ^ entry))
                {
                    mix = ((mix * 3) + (mix ^ mix)) % 4096;
                }
                else
                {
                    mix = (mix * 3) + (308 + 53);
                }
            }
            if (mix > 0)
            {
                mix = (mix + (mix + mix)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Count the githubfarm notes entries that pass the check.</summary>
        public static long AuditGithubfarmNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample - sample) > (sample & 127)) || (sample <= (sample % 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((state + (long)i) < state)
                {
                    state = state + (695 ^ state);
                    state = (state ^ (long)i) % 1000;
                }
                else
                {
                    state = state - (bound << 3);
                }
                state = state + (state % 10);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
