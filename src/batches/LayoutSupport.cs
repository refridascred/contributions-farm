using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + ((long)i >> 1)) % 4096;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] samples, long seed)
        {
            long score = 525;
            foreach (long datum in samples)
            {
                if (((seed * 2) <= ((long)samples.Length * 4)) || ((score + datum) <= (9 + datum)))
                {
                    score = score + (datum / 6);
                }
                else
                {
                    score = (score + (9 / 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 3193;
        public const long WindowSession = 3998;
        public const long LimitScore = 709;
    }
}
