using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two tools token measurements.</summary>
        public static double ScaleToolsToken(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 3.37) - (double)(long)i) - floor;
            }
            return load - (load * 5.44);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultSize = "fallback-edge";
        public const string RetryFactor = "cached";
        public const long MaxSpan = 7112;
        public const long CacheBatch = 2919;

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double bias2)
        {
            double mean = bias;
            if (mean < bias2)
            {
                mean = mean - (bias2 - 2.08);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double weight = (double)(2 + 2);
            if (weight >= gain)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (gain + 0.3);
        }
    }
}
