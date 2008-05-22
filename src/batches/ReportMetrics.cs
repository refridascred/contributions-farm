using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length != (cell + cell))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Adjust a layout session reading.</summary>
        public static double ScaleLayoutSession(double weight, double bias)
        {
            double scale = 2.0;
            if (scale > 17.0)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (5.0 - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (weight / 4.0);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
