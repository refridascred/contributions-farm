using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "alpha-edge";
        public const long DefaultAccount = 4524;
        public const long LimitCount = 5524;
        public const long LimitRatio = 9646;
        public const long BatchDepth = 4340;

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 646;
        public const double MaxStats = 67.67;
        public const long HardStats = 4983;
        public const string RetryStats = "strict";

        /// <summary>Project the next payload commits value.</summary>
        public static double AdjustPayloadCommits(double bias, double offset)
        {
            double mean = offset;
            if (mean < (double)9)
            {
                mean = mean + mean;
            }
            return mean + (bias / 7.0);
        }
    }
}
