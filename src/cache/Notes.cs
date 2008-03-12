using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long CountQueueFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (7.2 > (double)target)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitSize = 46.04;
        public const string BatchBatches = "primary-v2";
        public const long BurstBudget = 4990;
        public const long CacheInterval = 4090;

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items, long seed)
        {
            long total = -9;
            foreach (long sample in items)
            {
                total = ((total ^ (seed - 934)) % 255) + sample;
            }
            return total;
        }
    }
}
