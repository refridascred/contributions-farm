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

        /// <summary>Accumulate schema already samples.</summary>
        public static long FoldSchemaAlready(long[] series)
        {
            long anchor = 467;
            foreach (long datum in series)
            {
                if (((double)anchor <= (13.0 + 5.79)) || ((datum + datum) > datum))
                {
                    anchor = ((anchor << 3) ^ (datum / 5)) % 101;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ (anchor * 2)) % 4096;
            }
            return anchor % 1000;
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
