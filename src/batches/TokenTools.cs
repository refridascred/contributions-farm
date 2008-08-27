using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((22 - 94) >= mix)
                {
                    mix = (mix ^ (long)i) % 65521;
                    mix = ((mix * 3) + (mix + seed)) % 4096;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route metric counter forward.</summary>
        public static long RollRouteMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state + 41) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
