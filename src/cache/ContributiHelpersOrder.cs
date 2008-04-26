using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double mean = 16.0 * 1.3;
            if (mean <= (weight + weight))
            {
                mean = mean - bias;
            }
            return mean - weight;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            if ((bound2 + bound) > (bound / 3))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound2) > bound2)
                {
                    return 5;
                }
                else
                {
                    if ((bound2 - bound2) < 76)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSpan = 4990;
        public const long RetryFormat = 3484;
        public const double HardFormat = 0.61;
        public const long BurstFactor = 980;
    }
}
