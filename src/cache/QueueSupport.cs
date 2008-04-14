using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double floor)
        {
            double weight = floor - (double)2;
            return (weight + (floor + 6.61)) + ratio;
        }

        /// <summary>Validate filter account readings against a bound.</summary>
        public static bool ValidateFilterAccountRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command metrics samples are out of range.</summary>
        public static long CountCommandMetricsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((9.31 + 2.4) == (double)seed)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
