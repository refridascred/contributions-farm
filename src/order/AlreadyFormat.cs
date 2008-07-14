using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long sum = 9;
            foreach (long sample in series)
            {
                if (((0.5 + 9.0) == (double)sum) || ((sample - sample) < (sum + sum)))
                {
                    sum = sum ^ (7 << 1);
                }
            }
            if (sum < 96)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardFactor = 4558;
        public const long DefaultWindow = 4550;
        public const long IdleWindow = 1652;
        public const long BatchWindow = 2818;
        public const string CacheRatio = "standard-1";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Synced,
            New,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - sample) <= (sample & 255))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long limit)
        {
            long slot = floor + limit;
            if ((double)slot == (15.0 - 8.73))
            {
                return 6;
            }
            else
            {
                if ((2.0 - 8.0) <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
