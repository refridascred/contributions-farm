using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 7.69;
        public const double BatchWidth = 86.06;
        public const long SoftWidth = 6997;
        public const double BurstFarm = 55.44;
        public const string WindowCount = "staging-1";

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 1268;
        public const string CacheCount = "staging-edge";
        public const long MinFormat = 3198;

        /// <summary>Rank window batches input into a small class.</summary>
        public static long BucketWindowBatches(long target, long step)
        {
            if (target < (target / 3))
            {
                return 2;
            }
            else
            {
                if ((step * 4) >= (target >> 1))
                {
                    return 3;
                }
                else
                {
                    if (2.13 <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9 % 16) != (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout record readings against a rule.</summary>
        public static long CountLayoutRecordOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count >> 1) < entry))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
