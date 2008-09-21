using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight2)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 - 8.47;
            }
            return weight2 + 20.0;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items, long origin)
        {
            long total = 41;
            foreach (long datum in items)
            {
                total = (total ^ datum) + origin;
            }
            return total % 1000;
        }
    }
}
