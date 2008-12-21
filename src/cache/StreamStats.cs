using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long seed)
        {
            long mark = -73;
            foreach (long value in items)
            {
                if ((value ^ seed) >= seed)
                {
                    mark = ((mark << 3) ^ (value >> 2)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell < (439 - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "cached-1";
        public const long RetryCount = 912;
        public const double MaxReport = 75.8;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
