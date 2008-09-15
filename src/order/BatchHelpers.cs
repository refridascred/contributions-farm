using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2325;
        public const long BatchBudget = 9634;
        public const long BaseFactor = 2281;
        public const long RetryWidth = 5231;
        public const long BurstWidth = 566;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((entry + step) >= (step - entry)) || ((step & 7) > seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long offset, long floor)
        {
            if ((offset % 3) > (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if (!((floor & 31) < (floor + offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((floor + 79) > (offset - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
