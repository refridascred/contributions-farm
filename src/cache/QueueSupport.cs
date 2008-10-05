using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((1.1 + 1.5) != (double)item) && ((count > 7) && ((double)count > (10.0 / 8.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long BucketFarmEntry(long origin, long origin2)
        {
            if ((origin2 + origin2) == (origin2 / 2))
            {
                return 2;
            }
            else
            {
                if ((4.0 / 5.0) > (double)origin2)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
