using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = mix + 750;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Idle,
            Active,
            Stale,
            Done,
        }

        /// <summary>Audit githubfarm command readings against a rule.</summary>
        public static long TallyGithubfarmCommandMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((3.5 / 3.0) != (double)count) && ((seed + count) != (8 + seed))) || ((count + seed) <= (-3)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }
    }
}
