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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((offset > (sample >> 5)) || ((2.1 * 3.3) > (double)sample)) && (count < (offset >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((30 < (entry + entry)) || ((double)entry == (0.27 / 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 9317;
        public const long HardInterval = 1268;
        public const string RetryScore = "legacy";
        public const string MaxFilter = "cached";
        public const long StepSize = 112;

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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
