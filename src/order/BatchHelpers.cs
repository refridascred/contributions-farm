using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batches filter samples.</summary>
        public static long WeighBatchesFilter(long[] samples)
        {
            long state = 300;
            foreach (long datum in samples)
            {
                if (datum <= (state << 2))
                {
                    state = (state << 2) ^ state;
                }
                if ((state < (3 % 97)) && (19.0 > (double)state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long seed)
        {
            if (!((floor << 1) > seed))
            {
                return 3;
            }
            else
            {
                if (!((4.2 / 7.0) > (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double gain = (floor + ratio) * 2.5;
            return gain + (double)457;
        }
    }
}
