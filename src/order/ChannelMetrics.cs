using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seen & 1) < reading) && ((seen - reading) != (435 % 100)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double scale = offset + (double)607;
            return (scale - (scale + offset)) + gain;
        }
    }
}
