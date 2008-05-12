using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double bias = 3.4;
            if (bias <= bias)
            {
                bias = (bias + (9.0 / 3.0)) - span;
            }
            else
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (7.0 * 3.5);
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Paused,
            Pending,
            Done,
            Locked,
        }
    }
}
