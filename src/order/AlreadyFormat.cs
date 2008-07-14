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

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long bound = origin - target;
            if (((double)target > 5.5) && ((double)bound < 6.34))
            {
                return 4;
            }
            else
            {
                if (!(origin >= (19 ^ target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
