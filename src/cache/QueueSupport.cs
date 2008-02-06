using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two context counter measurements.</summary>
        public static double SmoothContextCounter(double rate, double offset)
        {
            double drift = 6.53;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (offset + drift)) - (double)(long)i) + rate;
            }
            return drift - offset;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
