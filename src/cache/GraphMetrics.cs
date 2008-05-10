using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "primary-1";
        public const double BatchEntry = 6.36;
        public const long MaxEntry = 5468;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((-1) / 3) >= (seen - reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((bound + bound) < (8 + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((limit - limit) < count))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((matches >= value) || ((double)value >= (9.52 * 7.5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
