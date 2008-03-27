using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 9437;
        public const long WindowLayout = 8141;
        public const long MinFactor = 6549;
        public const long RetryFactor = 7821;
        public const long CacheLayout = 8224;

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long TallyAlreadyCacheGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((-126) ^ datum) <= (matches - origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate layout batches readings against a bound.</summary>
        public static bool GuardLayoutBatchesBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Pending,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Done,
            Ready,
        }
    }
}
