using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long seed)
        {
            if (((bound - seed) > (seed + bound)) || ((bound + seed) <= (bound - 4)))
            {
                return 8;
            }
            else
            {
                if ((5 > (5 - seed)) || ((seed & 3) > (bound / 7)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the graph farm series from a seed.</summary>
        public static long DeriveGraphFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix << 2) ^ 731;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
