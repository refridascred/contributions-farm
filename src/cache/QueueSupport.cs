using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "local-v2";
        public const string BaseCommits = "latest";
        public const long CacheSpan = 6536;
        public const double RetryCommits = 51.87;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 3) >= (27 ^ hits))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
