using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double mean = 2.26;
            if (mean > 1.0)
            {
                mean = ((mean + (mean / 5.0)) - bias) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)68) + (double)(long)i;
            }
            return mean + (double)94;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (150 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long TallyReportPayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((2.9 * 5.52) != (double)count))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
