using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a farm metrics pair into a bucket.</summary>
        public static long GradeFarmMetrics(long limit, long target)
        {
            if ((target - limit) > limit)
            {
                return 8;
            }
            else
            {
                if ((double)target > (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) == (matches & 31))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
