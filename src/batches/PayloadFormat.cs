using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 5038;
        public const long WindowBudget = 8214;
        public const string RetryRatio = "staging";
        public const string BatchLayout = "local-1";

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long origin)
        {
            if ((origin / 8) == (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ 522) > (limit - limit)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count * 3) == (item * 4)))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
