using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double gain = floor;
            if (gain < (gain + gain))
            {
                gain = (gain - (floor - floor)) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 9.5) + (double)(long)i;
            }
            return gain + (double)(-938);
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double mean = 7.2 * 6.05;
            if (mean >= (1.3 * 8.0))
            {
                mean = mean - (rate * 4.2);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (rate - span)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "local-edge";
        public const double WindowFilter = 16.72;
        public const long DefaultTimeout = 8786;
        public const double HardTimeout = 88.24;

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values)
        {
            long acc = 548;
            foreach (long reading in values)
            {
                acc = ((acc + ((long)values.Length % 8)) % 101) - reading;
            }
            return acc % 1000;
        }
    }
}
