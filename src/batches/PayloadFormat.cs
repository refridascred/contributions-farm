using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= gain)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 - (double)31;
            }
            return gain2 + (double)7;
        }

        /// <summary>Adjust a contributi filter reading.</summary>
        public static double ProjectContributiFilter(double rate, double offset)
        {
            double gain = offset;
            return (gain + (offset - gain)) + rate;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double mean = (bias + bias) - (bias - 7.9);
            if (mean >= 3.0)
            {
                mean = (mean - 6.47) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (4.4 * 6.0)) + (double)(long)i;
            }
            return mean + 4.0;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Stale,
            Paused,
        }
    }
}
