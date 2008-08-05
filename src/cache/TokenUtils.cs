using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((17.0 > (double)matches) || ((double)datum > (double)2)) || (((datum / 4) <= (matches << 3)) && ((589 * 3) >= (datum + datum))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            long span = floor + limit;
            if ((8.91 <= (double)span) || ((floor + limit) >= limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (double)span)
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
