using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long acc = 5;
            foreach (long cell in items)
            {
                if ((7.0 - 18.0) >= (double)cell)
                {
                    acc = (acc - (acc << 1)) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ (cell - (long)items.Length);
                }
            }
            return acc;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long CountFarmGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((6.97 + 0.1) >= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
