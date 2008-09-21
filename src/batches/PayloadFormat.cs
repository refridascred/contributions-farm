using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double rate, double floor)
        {
            double mean = (double)(18 + 9);
            if (mean <= (double)509)
            {
                mean = (mean + 19.0) - rate;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (floor * 15.0)) + (double)(long)i;
            }
            return mean + (double)796;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Locked,
            Idle,
            Queued,
            Paused,
        }
    }
}
