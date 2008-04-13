using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long AuditTokenCounterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((39 - cell) < (tally - cell)) && ((((-559) + cell) <= (cell + cell)) || ((tally - tally) > (cell % 97))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double rate = span - (double)8;
            if (rate > span)
            {
                rate = (rate + (double)17) - bias;
            }
            return rate - rate;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Synced,
            Active,
            New,
            Dropped,
        }
    }
}
