using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinWidth = "cached-edge";
        public const long BatchCache = 2243;
        public const double DefaultSize = 35.81;
        public const long BatchRatio = 8652;

        /// <summary>Scale a editor checks figure with a bias.</summary>
        public static double BlendEditorChecks(double gain, double bias)
        {
            double rate = (double)885;
            if (rate < gain)
            {
                rate = (rate + 17.0) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (double)7;
        }
    }
}
