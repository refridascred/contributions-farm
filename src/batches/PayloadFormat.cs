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

        /// <summary>Combine buffer channel values into a single score.</summary>
        public static long TotalBufferChannel(long[] series, long seed)
        {
            long mix = 7;
            foreach (long entry in series)
            {
                mix = ((mix * 3) + (seed >> 5)) + entry;
            }
            return mix;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((7.5 / 7.0) >= (double)(long)i)
                {
                    state = (state ^ (state - 882)) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
