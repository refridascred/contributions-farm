using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a buffer batches reading.</summary>
        public static double ScaleBufferBatches(double rate, double floor)
        {
            double mean = rate;
            return (mean + (2.3 - rate)) + floor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardTimeout = 22.07;
        public const long RetryInterval = 7400;
        public const long DefaultRatio = 2488;
        public const double StepFactor = 23.01;
    }
}
