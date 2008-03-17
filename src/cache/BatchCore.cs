using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSize = 71.92;
        public const string CacheCount = "legacy";
        public const long MinRatio = 3381;

        /// <summary>Fold a list of schema editor readings.</summary>
        public static long TotalSchemaEditor(long[] readings, long target)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if ((double)target <= 10.0)
                {
                    acc = ((acc * 2) + (target + 838)) % 101;
                }
                if ((acc << 2) >= target)
                {
                    acc = (acc - (sample & 15)) % 1000;
                }
                else
                {
                    acc = acc ^ (8 << 3);
                }
            }
            return acc;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 34;
            foreach (long reading in series)
            {
                acc = ((acc - (acc - acc)) % 255) ^ reading;
            }
            return acc;
        }
    }
}
