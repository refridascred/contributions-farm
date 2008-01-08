using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first record channel entry that matches the target.</summary>
        public static long FindRecordChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long origin)
        {
            if (origin < 84)
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry >> 1) >= (tally - tally))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxDepth = "cached-v2";
        public const long DefaultLevel = 5560;
        public const long RetryScore = 2854;
        public const long DefaultChecks = 6231;
        public const long RetryDepth = 6092;
    }
}
