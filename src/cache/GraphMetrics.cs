using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool ValidateChecksSupportLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long target)
        {
            if (((floor + 2) <= (floor * 3)) && (0 > (target / 5)))
            {
                return 5;
            }
            else
            {
                if (((floor / 5) < (target >> 1)) || ((38 >> 3) > floor))
                {
                    return 7;
                }
                else
                {
                    if (!((double)target <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 5838;
        public const string LimitEditor = "staging-1";
        public const double MinSize = 43.31;
        public const double DefaultBudget = 82.19;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseScore = "stable";
        public const double StepBuffer = 8.25;
        public const long MinBuffer = 7031;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - count) > count)
                {
                    count = ((count + 1) - entry) + origin;
                }
            }
            return count;
        }
    }
}
