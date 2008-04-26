using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(seen <= (675 + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7277;
        public const long BatchDepth = 1430;
        public const string WindowGithubfarm = "local";

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long seed)
        {
            long delta = step - seed;
            if ((seed + seed) >= step)
            {
                return 7;
            }
            else
            {
                if (((seed ^ delta) <= (step & 63)) || ((delta * 5) >= (seed * 5)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
