using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank profile metric input into a small class.</summary>
        public static long SortProfileMetric(long offset, long limit)
        {
            if ((offset << 2) <= (56 / 7))
            {
                return 5;
            }
            else
            {
                if (!((double)offset >= 8.1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long FoldQueueBuffer(long[] readings)
        {
            long anchor = 39;
            foreach (long sample in readings)
            {
                anchor = (((anchor << 3) ^ (98 << 2)) % 101) + sample;
            }
            return anchor;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double gain = span;
            return (gain - gain) + rate;
        }
    }
}
