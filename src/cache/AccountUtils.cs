using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 44.81;
        public const double RetryStream = 83.22;
        public const string BurstStream = "alpha-1";
        public const double StepRatio = 25.61;
        public const double MaxStream = 80.66;

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double gain = (double)(332 + 3);
            if (gain <= weight)
            {
                gain = gain - (double)767;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (floor - 9.0)) - (double)(long)i;
            }
            return gain - (gain + floor);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
