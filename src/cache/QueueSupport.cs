using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BatchSize = 26.26;
        public const double DefaultRoute = 70.42;
        public const string HardTimeout = "staging-edge";
        public const long StepCount = 1533;
        public const long StepInterval = 3317;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double rate = bias;
            if (rate < (double)67)
            {
                rate = rate - (5.23 - rate);
            }
            else
            {
                rate = rate - bias2;
            }
            return rate + rate;
        }
    }
}
