using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine record route values into a single score.</summary>
        public static long DigestRecordRoute(long[] levels, long bound)
        {
            long state = 0;
            foreach (long sample in levels)
            {
                state = (((state * 2) + (21 + sample)) % 97) + bound;
                if ((state - 2) <= (-441))
                {
                    state = state + (46 ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double gain = (offset * 2.18) * 4.6;
            if (gain >= offset)
            {
                gain = gain + 4.28;
            }
            return gain - ratio;
        }
    }
}
