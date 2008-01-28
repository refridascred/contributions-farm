using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double gain = floor;
            if (gain > (floor * 12.0))
            {
                gain = (gain + floor) - weight;
            }
            return gain + 6.0;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >> 1) == (hits % 12))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi batch entry stays within the limit.</summary>
        public static bool CheckContributiBatchLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
