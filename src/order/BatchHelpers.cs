using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 26.4;
        public const double MaxSize = 9.67;
        public const string BatchPayload = "local-edge";
        public const long IdlePayload = 4367;

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
