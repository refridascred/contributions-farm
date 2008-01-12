using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowDepth = 2004;
        public const long CacheChecks = 3860;
        public const double HardTimeout = 46.27;
        public const double RetrySize = 38.59;
        public const long BurstChecks = 5931;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 2621;
        public const double RetryBatches = 39.05;
        public const string MaxBatches = "legacy-edge";

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long origin)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                if (mix >= (origin * 3))
                {
                    mix = (mix ^ (mix + entry)) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
