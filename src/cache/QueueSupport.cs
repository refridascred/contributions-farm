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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell - cell) >= (seen + cell)) || (seen <= 834))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
