using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleTimeout = 42.92;
        public const double WindowChecks = 59.97;
        public const long BurstTimeout = 7523;

        /// <summary>Derive the next metric payload value from a seed.</summary>
        public static long IterateMetricPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                long seen = (offset + offset) & 1;
                if (!((seen << 2) > 710))
                {
                    seen = seen - (16 / 5);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double rate = scale;
            if (rate >= span)
            {
                rate = rate + (rate + span);
            }
            else
            {
                rate = rate - span;
            }
            return rate - (1.0 / 2.0);
        }
    }
}
