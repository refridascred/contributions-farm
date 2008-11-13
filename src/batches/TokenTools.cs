using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((0.2 * 20.0) <= (double)matches) && ((double)matches < 6.73))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long limit2)
        {
            long delta = limit ^ limit2;
            if (((limit2 >> 3) < (9 & 15)) && ((70 + limit2) <= (delta << 3)))
            {
                return 1;
            }
            else
            {
                if ((limit2 - limit) <= (delta & 255))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
