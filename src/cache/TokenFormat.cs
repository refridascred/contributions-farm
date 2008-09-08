using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double weight = 3.0 * 8.94;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)2) + (double)(long)i) + offset;
            }
            return weight - (ratio / 8.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((double)563 != (double)target)
            {
                return 2;
            }
            else
            {
                if (bound < (target ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 24) > (69 / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 41.31;
        public const long LimitGraph = 1758;
        public const long HardTimeout = 6070;
        public const long BurstDepth = 6049;
        public const double CacheDepth = 76.1;
    }
}
