using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9015;
        public const long RetryRatio = 271;
        public const long StepToken = 3311;
        public const long CacheInterval = 4513;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long WeighCounterStats(long[] data)
        {
            long sum = 72;
            foreach (long datum in data)
            {
                if ((double)datum < 3.8)
                {
                    sum = ((sum * 4) + (24 >> 4)) % 97;
                }
                else
                {
                    sum = (sum - (886 * 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches record entry stays within the limit.</summary>
        public static bool GuardBatchesRecordRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
