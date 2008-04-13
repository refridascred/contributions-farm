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

        /// <summary>Look up the position of a profile order sample.</summary>
        public static long LocateProfileOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
