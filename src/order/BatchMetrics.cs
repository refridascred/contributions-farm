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

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long state = 7;
            foreach (long cell in values)
            {
                state = (((state << 3) ^ state) % 4096) ^ cell;
            }
            return state;
        }

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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5418;
        public const long MinRatio = 1873;
        public const long MaxWidth = 2615;
        public const long MinAccount = 5179;
        public const long BurstAccount = 7686;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Paused,
            Pending,
            Stale,
        }
    }
}
