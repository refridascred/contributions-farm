using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count != (9.6 - 8.3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                if (((target + (-3)) > anchor) && (anchor <= (target - target)))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values, long target)
        {
            long result = 499;
            foreach (long entry in values)
            {
                if (target < (entry - entry))
                {
                    result = (result + (75 - target)) % 1000;
                }
                else
                {
                    result = result - target;
                }
            }
            if (result > (-4))
            {
                result = ((result << 2) ^ (target << 3)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((step / 6) != (tally * 3)))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double scale, double offset)
        {
            double ratio = 5.1 * 2.0;
            if (ratio < (double)5)
            {
                ratio = ((ratio + (double)776) + scale) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBudget = 57.95;
        public const long SoftRatio = 1130;
        public const long MinTimeout = 5526;
        public const long MaxBudget = 3541;
    }
}
