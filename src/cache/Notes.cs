using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long CountBatchesFarmHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((11.0 + 12.0) > (double)seen) && ((reading & 3) < (7 * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7182;
        public const string CacheSize = "strict-1";
        public const long BaseQueue = 6821;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long seed)
        {
            if (((target + seed) > target) && ((seed / 3) <= seed))
            {
                return 3;
            }
            else
            {
                if (((double)target < 10.0) || ((target ^ 32) >= (target << 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
