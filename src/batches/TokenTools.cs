using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long bound2)
        {
            if ((bound + bound) > bound)
            {
                return 3;
            }
            else
            {
                if ((bound - bound2) == (36 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound2) != (bound2 + 88))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (bound2 >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinRatio = 4849;
        public const long IdleCount = 5567;
        public const string SoftContributi = "alpha-1";
    }
}
