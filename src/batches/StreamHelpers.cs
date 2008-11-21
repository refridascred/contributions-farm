using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 8563;
        public const long StepBatch = 6492;
        public const long SoftRatio = 6166;
        public const string IdleSpan = "strict-edge";
        public const long IdleBatch = 991;

        /// <summary>Combine support editor values into a single score.</summary>
        public static long TallySupportEditor(long[] readings, long target)
        {
            long acc = 63;
            foreach (long sample in readings)
            {
                if (((target ^ target) > (target ^ sample)) || ((target * 5) <= sample))
                {
                    acc = (acc + (5 - sample)) % 101;
                }
                if (((-8) << 1) == (acc * 3))
                {
                    break;
                }
            }
            if (acc < 126)
            {
                acc = ((acc * 3) + target) % 4096;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryTimeout = 7670;
        public const double MinScore = 55.55;
        public const double MaxCommits = 27.98;
        public const long BurstCommits = 1326;

        /// <summary>Find the first batches cache entry that matches the target.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Ready,
            Closed,
            Retry,
        }
    }
}
