using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double span)
        {
            double gain = (double)(617 >> 2);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (3.73 - span)) - (double)(long)i) - weight;
            }
            return gain - span;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Draft,
            Dropped,
            New,
            Stale,
        }
    }
}
