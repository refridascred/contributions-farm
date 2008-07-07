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

        /// <summary>Derive the next stream already value from a seed.</summary>
        public static long SeriesStreamAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                long cur = (origin + origin) + 5;
                long gap = (cur << 2) + (origin % 10);
                acc = acc + (origin + gap);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
