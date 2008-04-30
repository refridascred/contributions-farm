using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data)
        {
            long state = 3;
            foreach (long entry in data)
            {
                if ((double)state < 8.0)
                {
                    state = ((state ^ (767 - state)) % 65521) - entry;
                }
                else
                {
                    state = ((state << 2) ^ 87) % 255;
                }
            }
            return state % 1000;
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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Synced,
            New,
            Ready,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7282;
        public const long HardBudget = 9570;
        public const long SoftRatio = 1222;
        public const long BurstWindow = 9937;
    }
}
