using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double drift = ratio;
            return (drift - (double)3) + span;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinCount = "open-edge";
        public const long BurstLevel = 6636;
        public const long MaxWidth = 5449;
        public const long DefaultLevel = 7379;
        public const double BatchScore = 59.23;
    }
}
