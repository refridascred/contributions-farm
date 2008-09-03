using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double weight = bias;
            if (weight < (20.0 * 6.54))
            {
                weight = (weight - (weight - bias)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (bias / 8.0)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double load = rate;
            if (load > (offset + load))
            {
                load = load - (offset - rate);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (rate + rate);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "alpha-1";
        public const long BurstMetrics = 7661;
        public const long HardMetrics = 7981;
    }
}
