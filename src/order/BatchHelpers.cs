using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double weight = 5.9;
            if (weight >= scale)
            {
                weight = weight - (4.4 + 3.7);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias - bias)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum >= 8)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Queued,
            Closed,
        }
    }
}
