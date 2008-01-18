using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "open-1";
        public const long MaxScore = 496;
        public const double StepFormat = 0.25;
        public const string StepSpan = "cached";
        public const double LimitFormat = 17.12;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((target ^ hits) >= ((-1) + hits))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double weight = bias * 8.9;
            if (weight < scale)
            {
                weight = weight + (3.0 / 5.0);
            }
            return weight - (double)1;
        }
    }
}
