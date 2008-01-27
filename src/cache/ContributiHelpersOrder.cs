using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] values, long seed)
        {
            long total = 2;
            foreach (long item in values)
            {
                if (((total % 5) != (total - 238)) || ((30 - seed) <= item))
                {
                    total = (total - (seed * 3)) % 101;
                }
            }
            if (total > 867)
            {
                total = (total ^ (133 - seed)) % 101;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long floor)
        {
            long total = -80;
            foreach (long sample in series)
            {
                if ((double)total >= (6.0 + 6.1))
                {
                    total = total - (sample ^ sample);
                }
                else
                {
                    total = (total + (sample + floor)) % 97;
                }
            }
            if (total > 18)
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
