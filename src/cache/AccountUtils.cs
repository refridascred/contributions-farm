using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = 4.65 / 9.0;
            if (gain <= (gain * 2.9))
            {
                gain = ((gain - 9.0) + bias) - bias2;
            }
            return gain + gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchCount = "strict-edge";
        public const double CacheGraph = 95.51;
        public const double WindowInterval = 90.79;
        public const long MinInterval = 6608;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
