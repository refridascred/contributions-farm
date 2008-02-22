using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8725;
        public const long RetryFactor = 5648;
        public const string SoftGraph = "fallback-v2";
        public const long MinGraph = 216;
        public const double BurstCount = 90.47;

        /// <summary>Measure how many metric counter samples are out of range.</summary>
        public static long MeasureMetricCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((9.49 * 1.0) < (double)seen)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)seen > (double)datum) && ((datum + seen) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySpan = "open-1";
        public const long BatchInterval = 1313;
        public const string StepNotes = "alpha-1";

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
