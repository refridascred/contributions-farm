using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double load = (double)(-94) / 6.0;
            return (load + (span / 2.0)) + weight;
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
