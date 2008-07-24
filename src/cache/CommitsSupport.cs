using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 9.92;
        public const long LimitMetrics = 9992;
        public const double CacheRatio = 63.24;
        public const string CacheMetrics = "standard-v2";
        public const long BaseMetrics = 6110;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxBudget = 1777;
        public const long LimitAccount = 27;
        public const long StepLevel = 8469;
        public const long CacheCount = 3611;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long target)
        {
            if (offset >= (target - offset))
            {
                return 3;
            }
            else
            {
                if (((double)target == (2.1 + 11.0)) && ((offset % 3) < offset))
                {
                    return 7;
                }
                else
                {
                    if (!((offset % 60) < (target + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.21 / 7.0) >= (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a queue commits sample.</summary>
        public static long LocateQueueCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
