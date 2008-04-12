using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= (double)0)
            {
                bias2 = bias2 + bias;
            }
            return bias2 - rate;
        }

        /// <summary>Count the command profile entries that pass the check.</summary>
        public static long MeasureCommandProfileGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (13.0 <= (double)(long)values.Length)
                {
                    seen = ((seen + 3) + reading) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            New,
            Closed,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
