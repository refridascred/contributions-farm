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

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
