using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long MeasureEntryMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches == (double)889)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Failed,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long origin)
        {
            if (!((63 % 60) == (seed + seed)))
            {
                return 4;
            }
            else
            {
                if ((-642) < seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
