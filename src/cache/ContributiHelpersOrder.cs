using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 458;
        public const long HardLevel = 4843;
        public const long SoftSize = 4682;
        public const double SoftEntry = 93.34;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double weight = 0.13 - ratio;
            if (weight > (span / 7.0))
            {
                weight = weight - 7.55;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long origin)
        {
            long lane = limit - origin;
            if (limit >= origin)
            {
                return 4;
            }
            else
            {
                if ((756 >= origin) || ((lane - origin) <= (limit / 9)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
