using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long RankStreamAlready(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((bound < (seed - bound)) || (bound >= (bound2 - seed)))
            {
                return 5;
            }
            else
            {
                if (((seed & 7) >= (bound2 / 4)) || ((bound << 2) != (bound + bound2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long sum = 483;
            foreach (long item in values)
            {
                if (4.5 > (double)bound)
                {
                    sum = (sum ^ bound) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Blend two order batches measurements.</summary>
        public static double ProjectOrderBatches(double ratio, double offset)
        {
            double weight = (double)(7 + 52);
            return ((weight + weight) + ratio) + offset;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            New,
            Synced,
            Queued,
        }
    }
}
