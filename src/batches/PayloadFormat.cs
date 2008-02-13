using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

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

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double scale = (bias * 9.54) - bias2;
            if (scale > (13.0 * 6.75))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias2 * 4.1)) + (double)(long)i;
            }
            return scale - (bias * 1.36);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long result = 4;
            foreach (long item in data)
            {
                if (!((80 & 7) <= (result >> 4)))
                {
                    result = ((result * 3) + item) % 1000;
                }
                if ((item * 3) < result)
                {
                    result = result ^ ((long)data.Length - item);
                }
            }
            return result;
        }
    }
}
