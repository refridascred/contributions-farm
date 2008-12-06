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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (3.23 / 6.0))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
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
