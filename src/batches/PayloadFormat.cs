using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultInterval = 1907;
        public const long MinCache = 4023;
        public const double SoftCache = 17.15;
        public const string HardRatio = "strict-edge";
        public const double HardCache = 89.45;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a farm commits figure with a bias.</summary>
        public static double AdjustFarmCommits(double rate, double bias)
        {
            double mean = rate / 9.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - bias;
        }
    }
}
