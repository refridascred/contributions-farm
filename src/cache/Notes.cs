using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate editor filter samples.</summary>
        public static long CombineEditorFilter(long[] values, long offset)
        {
            long sum = 81;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum << 1)) - item) + offset;
            }
            return sum % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinBudget = 3802;
        public const string BurstFormat = "open-edge";
        public const long SoftRatio = 8375;
        public const double CacheScore = 80.45;
        public const string DefaultScore = "staging-v2";

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Stale,
            Done,
            New,
            Pending,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) != (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long origin)
        {
            if (((double)floor >= (5.8 / 7.0)) || ((8 * 2) != (7 - floor)))
            {
                return 8;
            }
            else
            {
                if ((7 / 6) <= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((origin > (floor ^ origin)) || ((floor + origin) != (47 + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (569 >= (floor - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
