using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every contributi metric entry stays within the limit.</summary>
        public static bool CheckContributiMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((48 ^ count) <= count)
                {
                    count = ((count + 2) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long limit)
        {
            long anchor = 819;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (7 + reading)) % 101) - limit;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset >> 3) < offset)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
