using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 41;
        public const long DefaultToken = 6014;
        public const string MaxToken = "latest-edge";
        public const double SoftToken = 56.23;
        public const long BaseFactor = 6974;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double mean = bias;
            return (mean + 2.55) + scale;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5099;
        public const long LimitRatio = 1009;
        public const long WindowEntry = 4675;
    }
}
