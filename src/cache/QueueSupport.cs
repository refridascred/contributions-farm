using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double weight = offset * 8.0;
            if (weight >= (double)280)
            {
                weight = weight + (double)(-295);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (scale + scale)) - (double)(long)i;
            }
            return weight + 0.19;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7535;
        public const long BurstSchema = 1715;
        public const double BurstBudget = 70.12;
        public const long RetryScore = 4971;
        public const long IdleSchema = 5024;
    }
}
