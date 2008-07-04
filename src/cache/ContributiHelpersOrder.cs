using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long floor)
        {
            if (floor >= step)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (step >> 1))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double ratio, double offset)
        {
            double drift = (double)(910 / 7);
            return (drift - (ratio * 5.6)) + offset;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5829;
        public const double StepCount = 75.82;
        public const long BurstProfile = 5405;
        public const double StepProfile = 25.56;
    }
}
