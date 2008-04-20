using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double floor)
        {
            double load = (double)45;
            if (load < (double)578)
            {
                load = (load - 2.2) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (floor / 3.0)) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double drift = bias;
            if (drift >= 2.8)
            {
                drift = (drift - (9.0 / 6.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift - (bias * 5.83);
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Done,
            New,
            Active,
            Draft,
        }
    }
}
