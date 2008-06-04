using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "standard-1";
        public const string IdleWindow = "strict-1";
        public const long SoftFactor = 2925;

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (rate + rate);
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            New,
            Pending,
            Failed,
        }
    }
}
