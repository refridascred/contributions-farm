using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (bias * 0.6))
            {
                scale = scale + (scale - weight);
            }
            return scale + 9.0;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double offset)
        {
            double ratio = (double)(68 * 2);
            if (ratio < offset)
            {
                ratio = (ratio + (double)460) - scale;
            }
            return ratio + (offset / 2.0);
        }

        /// <summary>Scale a farm route figure with a bias.</summary>
        public static double BlendFarmRoute(double scale, double floor)
        {
            double rate = 6.9;
            if (rate <= floor)
            {
                rate = (rate - (rate - 0.28)) + scale;
            }
            return rate + (double)247;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2656;
        public const long BurstSize = 2554;
        public const double BatchChecks = 10.55;
        public const long StepInterval = 8635;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3568;
        public const string MaxTimeout = "stable";
        public const string MinSession = "standard-1";
    }
}
