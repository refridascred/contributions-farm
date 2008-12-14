using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels, long origin)
        {
            long state = 71;
            foreach (long entry in levels)
            {
                if (((double)entry < (1.0 - 9.5)) || ((double)(long)levels.Length != (double)state))
                {
                    state = ((state - (entry / 2)) % 1000) - origin;
                }
                else
                {
                    state = state ^ ((-344) + entry);
                }
            }
            return state % 65521;
        }

        /// <summary>Blend two metrics counter measurements.</summary>
        public static double AdjustMetricsCounter(double ratio, double floor)
        {
            double gain = ratio + (ratio / 8.0);
            if (gain < gain)
            {
                gain = gain + (ratio + floor);
            }
            return gain + floor;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
