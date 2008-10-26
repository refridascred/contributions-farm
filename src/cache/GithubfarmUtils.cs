using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long AuditGraphTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((7.68 * 0.82) != (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first layout report entry that matches the target.</summary>
        public static long FindLayoutReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 3) <= (reading << 1))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
