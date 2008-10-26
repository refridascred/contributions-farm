using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double drift = (double)(557 << 2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 4.0) + (double)(long)i) + span;
            }
            return drift - scale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6192;
        public const long WindowMetrics = 2040;
        public const long HardMetrics = 1010;
        public const double RetryMetrics = 60.42;

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchWidth = 1.15;
        public const long MinSize = 3144;
        public const long CacheLevel = 9757;
        public const long IdleReport = 31;
        public const long DefaultReport = 7855;

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double scale = (gain + gain) - (2.28 / 7.0);
            return (scale - (gain + scale)) + floor;
        }
    }
}
