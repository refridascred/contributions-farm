using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long TallyCommandToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches % 7) < (reading % 64)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)limit == (13.0 - 5.0)) && !(value <= (limit & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - ((long)i << 2)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of layout metrics entries.</summary>
        public static long FoldLayoutMetrics(long[] samples)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                if ((414 + cell) != (total / 6))
                {
                    total = total ^ total;
                }
            }
            return total;
        }
    }
}
