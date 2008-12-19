using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double drift = 7.6 * 19.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - weight) + (double)(long)i) - offset;
            }
            return drift - (weight * 14.0);
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
