using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 8779;
        public const string StepSize = "fallback";
        public const string HardLevel = "stable";
        public const string MaxScore = "standard-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 23.29;
        public const double HardChecks = 46.34;
        public const double StepBudget = 4.56;
        public const long LimitChecks = 9549;
        public const long BatchChecks = 2560;

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (scale / 8.0);
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
        }
    }
}
