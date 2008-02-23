using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                if ((anchor >> 4) == (offset + anchor))
                {
                    anchor = (anchor << 3) ^ (cell ^ offset);
                }
                else
                {
                    anchor = (anchor << 2) ^ (8 << 2);
                }
            }
            return anchor;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 20.83;
        public const long MaxCluster = 8136;
        public const double StepCluster = 40.49;
        public const long HardWidth = 5857;
    }
}
