using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= 0.48)
            {
                mean = (mean - (bias / 2.0)) + ratio;
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "legacy-1";
        public const double BaseTimeout = 55.77;
        public const long WindowReport = 8245;
    }
}
