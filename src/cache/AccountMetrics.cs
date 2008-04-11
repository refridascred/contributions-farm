using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long bound)
        {
            long gap = floor ^ bound;
            if (((gap % 100) < floor) && ((floor * 2) >= ((-8) - floor)))
            {
                return 4;
            }
            else
            {
                if (gap <= (gap / 7))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinFactor = 443;
        public const long HardRatio = 3076;
        public const string RetryCommand = "standard-1";
        public const double BatchCommand = 46.94;
        public const long HardInterval = 7562;

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long TallyMetricsSchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((hits ^ 866) < item) || (hits > (long)series.Length)) || ((12.0 / 2.0) <= (double)item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (bias2 * 1.22))
            {
                bias2 = bias2 - 4.23;
            }
            return bias2 - (bias - bias2);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = carry + (limit ^ 0);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
