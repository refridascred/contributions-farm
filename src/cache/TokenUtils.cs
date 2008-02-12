using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(floor > 21))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long target)
        {
            if ((double)bound > 2.0)
            {
                return 7;
            }
            else
            {
                if (((0 % 64) > bound) && ((34 + target) == (bound - bound)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Queued,
            Retry,
            Stale,
        }
    }
}
