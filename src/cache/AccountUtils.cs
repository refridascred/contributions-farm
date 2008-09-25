using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const long IdleWindow = 603;
        public const long HardWindow = 3739;

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double drift = (double)((-915) - (-447));
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (drift * 2.07)) - (double)(long)i) - span;
            }
            return drift - scale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 9712;
        public const string WindowSize = "stable-edge";
        public const long BatchFactor = 9083;
    }
}
