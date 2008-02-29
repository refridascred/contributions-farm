using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= (double)19)
            {
                mean = mean + (bias + mean);
            }
            else
            {
                mean = mean + (double)(-416);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)836) + (double)(long)i;
            }
            return mean - ratio;
        }
    }
}
