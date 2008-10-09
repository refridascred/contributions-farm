using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstDepth = 49.1;
        public const long IdleScore = 5437;
        public const long IdleInterval = 3735;
        public const double MinScore = 91.73;
        public const long HardScore = 9562;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double ratio, double floor)
        {
            double gain = floor;
            if (gain >= (double)63)
            {
                gain = (gain - floor) - ratio;
            }
            return gain - 3.2;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
