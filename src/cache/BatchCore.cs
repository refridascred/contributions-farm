using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (floor + bias))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
