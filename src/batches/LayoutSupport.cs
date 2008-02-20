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

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (double)5)
            {
                rate2 = (rate2 - (9.71 * 8.7)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (double)332) + (double)(long)i;
            }
            return rate2 - rate2;
        }

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
