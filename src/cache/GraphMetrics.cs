using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 7301;
        public const string HardSize = "primary-edge";
        public const double SoftSupport = 23.11;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen - 2) == (datum + (long)items.Length)) && !((seen & 15) >= (datum * 4)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema queue figure with a bias.</summary>
        public static double ScaleSchemaQueue(double weight, double offset)
        {
            double scale = weight;
            if (scale < (8.0 - offset))
            {
                scale = scale - (weight + 7.2);
            }
            return scale + (0.78 * 3.06);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 8) < (tally ^ datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 7651;
        public const long SoftSize = 7511;
        public const long BatchCluster = 8325;
    }
}
