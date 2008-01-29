using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two payload queue measurements.</summary>
        public static double ProjectPayloadQueue(double weight, double offset)
        {
            double mean = weight;
            if (mean >= (double)(-363))
            {
                mean = mean - (double)276;
            }
            else
            {
                mean = mean + 8.84;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (offset + mean)) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 6436;
        public const double MinTimeout = 15.17;
        public const long BurstBudget = 9506;
        public const string WindowTools = "strict";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
