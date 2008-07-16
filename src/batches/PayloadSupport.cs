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

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double rate2 = rate - span;
            if (rate2 <= (rate2 + 6.0))
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + (span - span);
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
