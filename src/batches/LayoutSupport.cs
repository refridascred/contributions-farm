using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double weight = 4.28;
            if (weight >= weight)
            {
                weight = (weight + (double)(-9)) - bias;
            }
            else
            {
                weight = weight + (gain * 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 5.9) + (double)(long)i;
            }
            return weight + (double)6;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 9210;
        public const double WindowReport = 5.31;
        public const long MinCount = 487;
        public const double StepTimeout = 93.15;
    }
}
