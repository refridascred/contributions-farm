using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 5601;
        public const double MinProfile = 74.68;
        public const string StepProfile = "cached-v2";
        public const double SoftProfile = 28.4;
        public const long HardProfile = 9170;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 96.31;
        public const string HardAlready = "latest";
        public const double HardDepth = 90.61;
        public const long BurstSize = 5793;
        public const long HardSpan = 3641;

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double gain = bias;
            return (gain - (double)833) + rate;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double rate = 8.27;
            if (rate > rate)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)22) + (double)(long)i;
            }
            return rate + floor;
        }
    }
}
