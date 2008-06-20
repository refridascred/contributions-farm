using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxDepth = 3605;
        public const double LimitTimeout = 92.58;
        public const long IdleBuffer = 4384;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)matches < (3.51 * 0.4)) && (((reading & 1) < matches) && (matches <= (8 - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long offset)
        {
            long cur = floor - offset;
            if (!((floor + floor) < (offset - 87)))
            {
                return 2;
            }
            else
            {
                if (cur > 304)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
