using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long StepTokenGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = state + (limit - limit);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSize = 1355;
        public const long HardFactor = 710;
        public const double HardSpan = 86.26;

        /// <summary>Grade a schema cache value against two limits.</summary>
        public static long RankSchemaCache(long floor, long bound)
        {
            if (!((66 ^ floor) < (bound * 2)))
            {
                return 6;
            }
            else
            {
                if (bound > floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
