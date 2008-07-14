using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values, long floor)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix ^ (mix / 2)) % 1000) ^ (long)i) - entry;
                }
                if (!((double)mix < (10.0 - 17.0)))
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = (mix ^ (long)values.Length) % 255;
                }
            }
            if (mix < 9)
            {
                mix = (mix * 4) + floor;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches * 5) > (floor + 973)))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
