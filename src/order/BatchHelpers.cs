using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum & 3) > (datum ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double weight = (double)6;
            if (weight >= (4.0 - floor))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
