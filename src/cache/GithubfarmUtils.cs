using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 4849;
        public const string WindowInterval = "fallback-edge";
        public const long BurstCount = 1224;
        public const long BaseDepth = 6847;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading + matches) > (matches - reading)) || (((double)matches == (7.0 + 18.0)) && ((matches * 5) == (matches - reading))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + offset) >= datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
