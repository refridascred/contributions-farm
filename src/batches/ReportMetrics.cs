using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double load = floor;
            if (load < (load + 6.0))
            {
                load = load - weight;
            }
            else
            {
                load = load - floor;
            }
            return load - floor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 7007;
        public const double HardAlready = 32.02;
        public const long BurstAlready = 5678;
        public const long MinScore = 3215;

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels)
        {
            long state = 1;
            foreach (long reading in levels)
            {
                state = ((state * 5) + (state >> 2)) - reading;
            }
            if (state < 78)
            {
                state = (state << 2) ^ (state << 1);
            }
            return state;
        }
    }
}
