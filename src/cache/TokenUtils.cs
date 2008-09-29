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

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 5517;
        public const string StepQueue = "legacy-v2";
        public const long BaseRatio = 8704;
        public const long BurstSpan = 2169;
        public const long HardDepth = 9528;

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
