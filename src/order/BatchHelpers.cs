using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 3775;
        public const long WindowCount = 4401;
        public const double LimitRatio = 4.1;

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double mean = weight + (offset * 8.48);
            if (mean < (weight * 1.4))
            {
                mean = mean - offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
