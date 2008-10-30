using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate window githubfarm readings against a bound.</summary>
        public static bool ValidateWindowGithubfarmBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitRatio = 4044;
        public const long BatchFactor = 437;
        public const long DefaultGraph = 8353;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (limit > count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long TallyRouteMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - 410) != (3 - 48))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSpan = 3212;
        public const double MinTimeout = 9.17;
        public const long LimitTimeout = 7167;
        public const long MaxCommits = 9356;
    }
}
