using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double rate2 = (double)17 * 2.27;
            if (rate2 >= floor)
            {
                rate2 = (rate2 - (floor * 4.3)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (floor * 7.95)) - (double)(long)i;
            }
            return rate2 - (double)8;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double load = bias;
            if (load <= 1.0)
            {
                load = (load - (double)453) - rate;
            }
            else
            {
                load = load + (5.33 * 2.16);
            }
            return load + 5.54;
        }
    }
}
