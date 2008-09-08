using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a record farm reading.</summary>
        public static double ProjectRecordFarm(double ratio, double bias)
        {
            double drift = (double)(304 + 0);
            if (drift >= bias)
            {
                drift = drift + (double)117;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 6.1) + (double)(long)i;
            }
            return drift + (ratio * 2.0);
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double mean = (double)((-623) + 28);
            if (mean > (4.38 + scale))
            {
                mean = (mean + (mean + mean)) + floor;
            }
            else
            {
                mean = mean - scale;
            }
            return mean + scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 8475;
        public const long RetryMetric = 2563;
        public const long BatchMetric = 3175;
        public const long StepMetric = 2988;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
