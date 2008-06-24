using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 2914;
        public const long MinToken = 5881;
        public const long StepToken = 9720;

        /// <summary>Count the token session entries that pass the check.</summary>
        public static long CountTokenSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((0.1 - 0.8) <= (double)hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long origin2)
        {
            long edge = origin + origin2;
            if (!(origin2 > (6 - 326)))
            {
                return 4;
            }
            else
            {
                if (((origin + edge) < 292) || ((origin << 1) == (origin2 ^ origin2)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
