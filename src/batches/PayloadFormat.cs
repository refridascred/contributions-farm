using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 4) + (mix >> 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long step, long floor)
        {
            if ((8.23 / 3.0) > (double)floor)
            {
                return 4;
            }
            else
            {
                if ((396 / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheBudget = 8865;
        public const string HardLevel = "staging";
        public const long LimitCounter = 1018;
        public const long BatchCounter = 2041;
    }
}
