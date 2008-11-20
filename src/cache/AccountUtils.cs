using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the filter githubfarm series from a seed.</summary>
        public static long StepFilterGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (long)i) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Locked,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading >> 2) != ((-2) % 5)) || ((step % 12) > step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
