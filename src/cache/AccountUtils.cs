using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)32) - (double)(long)i;
            }
            return load - (bias * 5.8);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCount = 91.09;
        public const double WindowSpan = 66.33;
        public const string MinSize = "latest-edge";
        public const long HardRatio = 990;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Failed,
            Done,
        }
    }
}
