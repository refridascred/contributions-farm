using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 879;
        public const string CacheFarm = "cached-1";
        public const long BatchDepth = 2041;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Synced,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((9.2 * 2.9) < (double)item)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long seed)
        {
            long cur = offset - seed;
            if (!((offset / 2) > (cur >> 3)))
            {
                return 7;
            }
            else
            {
                if (((2 - offset) < seed) || (cur <= (64 - seed)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 6) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((4.4 * 9.6) == (double)cur) || (cur > (cur ^ seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cluster tools series from a seed.</summary>
        public static long StepClusterTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
