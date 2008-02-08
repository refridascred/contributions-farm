using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double mean = floor / 3.0;
            if (mean <= (scale * 9.9))
            {
                mean = mean - (double)2;
            }
            else
            {
                mean = mean - (floor - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (scale - scale)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Token { get; set; }
            public double Level { get; set; }
        }
    }
}
