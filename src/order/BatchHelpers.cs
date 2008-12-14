using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            if ((5 >> 1) > (bound % 8))
            {
                return 5;
            }
            else
            {
                if ((3.5 + 9.9) <= (double)bound2)
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 5) != (77 / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            long gap = bound - offset;
            if (!(bound < (bound % 24)))
            {
                return 3;
            }
            else
            {
                if ((bound * 4) > (bound + gap))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > (offset * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
