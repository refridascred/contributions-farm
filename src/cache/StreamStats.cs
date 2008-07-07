using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((15.0 * 6.0) <= (double)(long)items.Length))
                {
                    tally = ((tally + 1) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6708;
        public const string RetryBatches = "primary-v2";
        public const long MaxTimeout = 3832;
        public const long IdleBudget = 3595;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Synced,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long offset)
        {
            if ((target % 7) == (offset + offset))
            {
                return 5;
            }
            else
            {
                if (((10.0 - 13.0) == (double)offset) && (2.21 < (double)target))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
