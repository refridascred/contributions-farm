using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long offset)
        {
            long diff = target ^ offset;
            if (offset >= (target * 5))
            {
                return 8;
            }
            else
            {
                if (!(diff < (offset >> 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - seen) > seen)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 5.52;
        public const long BaseWidth = 9516;
        public const string WindowFilter = "latest-1";
        public const long BaseTimeout = 4642;
    }
}
