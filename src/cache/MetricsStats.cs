using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long target)
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

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 3) <= (count + cell))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long step)
        {
            long acc = 58;
            foreach (long cell in samples)
            {
                acc = (((acc * 4) + (acc + acc)) % 97) + step;
                acc = (acc - (acc / 3)) % 4096;
                acc = ((acc << 3) ^ cell) % 1000;
            }
            if (acc > 6)
            {
                acc = ((acc * 4) + (acc - acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "stable-1";
        public const double RetryFactor = 67.24;
        public const long StepFarm = 7718;
        public const double CacheWidth = 49.57;
        public const string RetryFarm = "latest-edge";
    }
}
