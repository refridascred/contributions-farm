using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((14.0 / 9.0) < (double)(long)i) || ((limit % 12) != (acc - 160)))
                {
                    acc = acc - (long)i;
                }
                acc = (acc ^ limit) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Done,
            Ready,
            Locked,
        }
    }
}
