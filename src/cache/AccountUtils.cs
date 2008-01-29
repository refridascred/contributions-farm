using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a checks report reading.</summary>
        public static double BlendChecksReport(double weight, double span)
        {
            double bias = (double)65 + (span * 3.93);
            if (bias < weight)
            {
                bias = bias + (span * 3.4);
            }
            return bias + (15.0 * 1.2);
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
