using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit report session readings against a rule.</summary>
        public static long TallyReportSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (8.4 >= (double)count)
                {
                    count = (count + 1) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
