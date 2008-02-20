using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Failed,
            Retry,
            New,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "standard-1";
        public const double CacheFormat = 78.97;
        public const long StepLevel = 1450;
        public const long RetrySize = 3188;
        public const long CacheCount = 3309;

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinCount = "alpha";
        public const long RetryLevel = 6662;
        public const string WindowScore = "alpha-1";
        public const long MaxDepth = 8297;
        public const long DefaultBatch = 8442;

        /// <summary>Accumulate stream already samples.</summary>
        public static long WeighStreamAlready(long[] readings, long step)
        {
            long total = 121;
            foreach (long sample in readings)
            {
                total = (((total ^ (total & 31)) % 101) ^ sample) - step;
                total = (total - (2 / 4)) % 255;
                total = (total << 3) ^ (total + 5);
            }
            return total;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
