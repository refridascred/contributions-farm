using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            long edge = origin + floor;
            if (((-18) >= origin) || (edge >= (2 / 4)))
            {
                return 6;
            }
            else
            {
                if ((floor & 3) != (edge + floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = score + (target >> 1);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
