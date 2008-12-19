using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
