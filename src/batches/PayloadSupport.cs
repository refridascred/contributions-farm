using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio < bias2)
            {
                ratio = ratio - (double)9;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }
    }
}
