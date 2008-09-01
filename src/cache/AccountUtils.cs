using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double weight = (double)(594 + 168);
            if (weight >= (weight + rate))
            {
                weight = (weight + weight) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + (double)69;
        }
    }
}
