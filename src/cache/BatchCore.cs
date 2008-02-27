using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a counter filter pair into a bucket.</summary>
        public static long ClassifyCounterFilter(long target, long target2)
        {
            if ((target2 / 3) < (target2 + target2))
            {
                return 8;
            }
            else
            {
                if (91 > target2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1471;
        public const long MaxWidth = 4243;
        public const string BatchBudget = "latest-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchCount = 7854;
        public const long BatchRatio = 9126;
        public const double MinInterval = 78.86;
        public const long RetryInterval = 5672;
    }
}
