using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 45.79;
        public const long BaseCount = 7945;
        public const long WindowFormat = 1645;

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleSize = 45.56;
        public const string HardCommand = "standard-v2";
        public const string BatchCommand = "open";
        public const long DefaultCommand = 8130;

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double mean = (double)888 - span;
            if (mean < gain)
            {
                mean = mean - (1.0 - gain);
            }
            return mean + (mean + mean);
        }
    }
}
