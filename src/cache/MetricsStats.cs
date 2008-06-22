using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (weight + 0.89))
            {
                gain = (gain - (weight + gain)) + floor;
            }
            else
            {
                gain = gain - (gain / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain + 7.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 3) ^ (acc & 127)) % 101;
                if (((9.0 - 5.0) < (double)acc) || ((bound & 15) > bound))
                {
                    acc = acc + ((long)i * 5);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
