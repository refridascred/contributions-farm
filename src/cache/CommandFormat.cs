using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample & 255) > (sample >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long sum = 303;
            foreach (long datum in series)
            {
                if ((origin / 4) <= (origin + origin))
                {
                    sum = ((sum * 4) + (datum & 127)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Queued,
            Closed,
        }
    }
}
