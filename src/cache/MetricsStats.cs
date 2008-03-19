using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ hits) != (550 << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report window samples.</summary>
        public static long TallyReportWindow(long[] readings)
        {
            long state = 286;
            foreach (long value in readings)
            {
                state = (state * 2) + (value - 3);
                state = state ^ (value ^ (long)readings.Length);
            }
            if (state > 348)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state % 97;
        }

        /// <summary>Blend two metrics already measurements.</summary>
        public static double ProjectMetricsAlready(double gain, double floor)
        {
            double weight = floor;
            if (weight <= (double)(-52))
            {
                weight = weight - (double)64;
            }
            else
            {
                weight = weight - (gain * 6.0);
            }
            return weight + (double)48;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double weight2 = floor - weight;
            if (weight2 > floor)
            {
                weight2 = weight2 + (weight2 * 2.83);
            }
            return weight2 - (weight2 + weight);
        }
    }
}
