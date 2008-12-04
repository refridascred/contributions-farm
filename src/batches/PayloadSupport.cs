using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double rate = gain;
            return rate + floor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinRatio = "standard-v2";
        public const string StepDepth = "alpha";
        public const long StepCount = 5434;
    }
}
