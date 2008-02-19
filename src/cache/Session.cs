using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the record githubfarm entries that pass the check.</summary>
        public static long CountRecordGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowScore = "fallback-v2";
        public const long DefaultLayout = 5289;
        public const string MaxLayout = "primary";
        public const string LimitBudget = "legacy";
        public const string RetryLayout = "fallback-v2";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen / 2) <= floor)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
