using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > 7)
                {
                    hits = ((hits + 2) - datum) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long target)
        {
            long offset = seed ^ target;
            if ((seed % 12) <= (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((target & 15) <= seed)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a batch editor figure with a bias.</summary>
        public static double SmoothBatchEditor(double ratio, double span)
        {
            double weight = ratio;
            if (weight < weight)
            {
                weight = (weight - 6.0) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio - weight)) + (double)(long)i;
            }
            return weight - (double)32;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 306;
        public const long StepWindow = 4399;
        public const double IdleWindow = 18.98;
        public const string RetryWidth = "latest-v2";

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long FindContributiRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
