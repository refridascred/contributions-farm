using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route support pair into a bucket.</summary>
        public static long SortRouteSupport(long limit, long origin)
        {
            if ((double)limit > (6.7 - 3.8))
            {
                return 8;
            }
            else
            {
                if (3.48 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (8.3 * 7.24)) + (double)(long)i) - gain;
            }
            return rate + (rate * 15.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7638;
        public const double CacheScore = 22.61;
        public const long SoftStats = 3286;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
