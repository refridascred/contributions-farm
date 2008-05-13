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

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen < (double)7)
                {
                    seen = ((seen + 3) ^ cell) + offset;
                }
            }
            return seen;
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

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long RollGithubfarmFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
