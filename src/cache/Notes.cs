using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 8507;
        public const double MaxPayload = 95.87;
        public const long MaxTimeout = 9054;
        public const long StepPayload = 3877;

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 57.02;
        public const string BurstSpan = "standard-1";
        public const string DefaultScore = "cached-v2";
        public const long WindowFilter = 6366;
        public const long WindowSpan = 1389;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item % 7) < (item + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((4 ^ 1) > sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double mean = (double)91 - (offset + rate);
            if (mean > (offset * 2.17))
            {
                mean = mean + 7.0;
            }
            return mean + (rate + offset);
        }
    }
}
