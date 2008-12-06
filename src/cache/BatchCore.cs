using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long floor)
        {
            if ((double)bound < (double)2)
            {
                return 2;
            }
            else
            {
                if (!((359 - floor) <= (946 * 3)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item - matches) <= (matches * 2)) && ((double)matches <= 6.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 3554;
        public const string BatchCommits = "primary";
        public const long RetryInterval = 8777;
        public const string SoftTimeout = "primary-1";

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (989 <= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
