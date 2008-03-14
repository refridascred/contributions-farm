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

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
