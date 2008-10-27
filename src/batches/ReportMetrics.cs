using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double bias = floor / 7.0;
            if (bias >= (floor / 3.0))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias + (15.0 * 17.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (ratio + floor);
        }

        /// <summary>Validate schema stream readings against a bound.</summary>
        public static bool GuardSchemaStreamBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
