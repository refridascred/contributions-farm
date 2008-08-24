using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long SortPayloadAccount(long target, long step)
        {
            long gap = target - step;
            if ((double)target == (2.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((gap - 80) == (target - target))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) == (cell + matches))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Locked,
            Stale,
            Dropped,
        }
    }
}
