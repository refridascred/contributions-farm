using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double weight2 = span / 7.0;
            if (weight2 < (12.0 / 9.0))
            {
                weight2 = (weight2 + 3.0) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (1.0 / 7.0)) + (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepFactor = 290;
        public const long SoftCluster = 6845;
        public const double DefaultCluster = 17.37;
        public const long MinRatio = 5714;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Dropped,
            Ready,
            Draft,
        }
    }
}
