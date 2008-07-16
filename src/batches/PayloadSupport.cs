using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the order tools series from a seed.</summary>
        public static long SeriesOrderTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                long offset = (target - (long)i) + (target - sum);
                long hits = (offset << 3) - sum;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum + hits) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ (bound >> 1)) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
