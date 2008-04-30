using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double bias)
        {
            double drift = (double)46 * 9.9;
            if (drift < (scale * 4.0))
            {
                drift = drift - scale;
            }
            return drift - (bias + bias);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double gain, double floor)
        {
            double mean = gain;
            if (mean < mean)
            {
                mean = (mean - mean) + floor;
            }
            else
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + 4.19;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight + (bias * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (4.05 / 9.0)) + (double)(long)i;
            }
            return weight + (5.48 * 9.1);
        }
    }
}
