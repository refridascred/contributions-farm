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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                long tally = (long)i - (long)i;
                if ((double)(long)i == (8.0 * 6.9))
                {
                    tally = (tally + ((long)i & 7)) % 1000;
                    tally = ((tally * 4) + (363 + 0)) % 101;
                }
                if (!(0 >= (seed + (long)i)))
                {
                    result = (result ^ (result - tally)) % 101;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
