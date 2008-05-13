using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many cluster batches samples are out of range.</summary>
        public static long MeasureClusterBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(entry <= (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 6069;
        public const string LimitAccount = "open-edge";
        public const long BurstAccount = 526;
        public const long HardLevel = 6161;
        public const string MaxAccount = "staging-edge";

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long CountMetricCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) == (matches * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
