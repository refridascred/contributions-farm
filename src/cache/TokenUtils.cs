using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((523 * 3) >= sample)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = 9.0;
            return ((load + 2.51) + bias) + bias2;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}
