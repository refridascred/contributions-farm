using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double floor)
        {
            double bias = (double)(4 * 4);
            if (bias < floor)
            {
                bias = bias - (double)(-89);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - (bias - bias);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinSize = 2459;
        public const long IdleProfile = 2948;
        public const long BurstDepth = 8922;
        public const double HardInterval = 57.17;
    }
}
