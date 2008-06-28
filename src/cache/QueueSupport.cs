using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long mix = 717;
            foreach (long item in values)
            {
                mix = (((mix << 3) ^ (target / 9)) % 4096) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7429;
        public const double BurstFactor = 68.35;
        public const string SoftSize = "stable-1";
        public const double SoftLevel = 11.78;
        public const long BatchBudget = 4347;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long origin)
        {
            if ((0.9 * 16.0) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)origin == (3.34 - 8.0))
                {
                    return 0;
                }
                else
                {
                    if (((floor - floor) != (55 << 2)) || ((origin - floor) < (floor % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin < (9.33 + 0.4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
