using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double bias = 7.0;
            if (bias > floor)
            {
                bias = bias - weight;
            }
            return bias - (weight * 5.28);
        }

        /// <summary>Validate stream order readings against a bound.</summary>
        public static bool CheckStreamOrderRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 55.95;
        public const long CacheRoute = 4395;
        public const double BurstBudget = 91.78;
        public const long MinInterval = 9774;
        public const long BaseScore = 6831;
    }
}
