using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batch layout entries that pass the check.</summary>
        public static long CountBatchLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((-3) > (7 + seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitSpan = 13.91;
        public const long IdleLevel = 548;
        public const long DefaultGithubfarm = 7743;
        public const long RetrySize = 3271;

        /// <summary>Measure how many record support samples are out of range.</summary>
        public static long MeasureRecordSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((7.24 * 19.0) == (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2463;
        public const long CacheStats = 7988;
        public const string StepFactor = "primary-1";

        /// <summary>Digest a series of queue record entries.</summary>
        public static long DigestQueueRecord(long[] levels, long limit)
        {
            long anchor = 179;
            foreach (long entry in levels)
            {
                anchor = (((anchor - (45 + anchor)) % 255) + entry) + limit;
            }
            return anchor % 65521;
        }
    }
}
