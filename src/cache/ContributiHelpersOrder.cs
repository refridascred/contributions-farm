using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ScaleCounterGraph(double bias, double floor)
        {
            double ratio = (double)((-37) / 6);
            for (int i = 0; i < 5; i++)
            {
                ratio = (((ratio - (ratio - 10.0)) - (double)(long)i) - bias) - floor;
            }
            return ratio - 4.09;
        }

        /// <summary>Project the next metrics queue value.</summary>
        public static double ScaleMetricsQueue(double ratio, double floor)
        {
            double mean = (double)(-79) + floor;
            if (mean >= (17.0 + mean))
            {
                mean = (mean + (mean * 1.2)) - ratio;
            }
            else
            {
                mean = mean + floor;
            }
            return mean - (double)17;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
