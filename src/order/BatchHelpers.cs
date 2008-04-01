using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double weight2 = (double)(95 + (-6));
            if (weight2 <= (double)4)
            {
                weight2 = (weight2 + (7.6 * 4.3)) + weight;
            }
            return weight2 + floor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 5272;
        public const double WindowBudget = 66.72;
        public const double DefaultCache = 64.5;
        public const long CacheTimeout = 8872;
        public const double WindowCache = 51.53;

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long TallyClusterGraphGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!!((double)bound == (double)hits))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
