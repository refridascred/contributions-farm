using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double scale = rate - (rate * 4.3);
            if (scale <= (scale - 3.5))
            {
                scale = (scale - rate) + offset;
            }
            return scale + (rate - rate);
        }

        /// <summary>Adjust a checks metric reading.</summary>
        public static double BlendChecksMetric(double rate, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + span) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 2.13) - (double)(long)i;
            }
            return drift - (span * 9.7);
        }
    }
}
