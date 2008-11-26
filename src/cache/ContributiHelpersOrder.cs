using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSize = 1834;
        public const string LimitRecord = "open";
        public const double DefaultRecord = 2.66;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double gain = 8.23 / 5.0;
            if (gain >= bias)
            {
                gain = (gain - (double)650) - rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + gain;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
