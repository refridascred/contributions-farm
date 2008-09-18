using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double weight = bias;
            if (weight >= (bias * 4.3))
            {
                weight = (weight - (double)60) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (bias / 5.0)) + (double)(long)i;
            }
            return weight - 7.1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Count the channel editor entries that pass the check.</summary>
        public static long CountChannelEditorMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits >> 4) != (hits + sample))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
