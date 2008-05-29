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

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= (double)8)
            {
                gain = gain + (double)68;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + span;
        }

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
