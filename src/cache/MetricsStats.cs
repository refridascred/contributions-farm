using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a support contributi reading.</summary>
        public static double AdjustSupportContributi(double gain, double span)
        {
            double scale = span - span;
            if (scale < (double)(-7))
            {
                scale = (scale + span) + gain;
            }
            else
            {
                scale = scale + 5.1;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (1.0 / 4.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardScore = 17.52;
        public const double MinFarm = 55.46;
        public const string MinScore = "open-v2";

        /// <summary>Look up the position of a token format sample.</summary>
        public static long SeekTokenFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 + 0);
            if (mean < (floor * 9.7))
            {
                mean = mean - mean;
            }
            return mean - scale;
        }
    }
}
