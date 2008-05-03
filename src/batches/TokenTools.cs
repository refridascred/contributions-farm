using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((4 + item) == (item + item)) && ((2.0 / 9.0) <= (double)tally)) || ((double)tally == (7.94 + 1.53)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 3) >= entry)
                {
                    seen = (seen + 2) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
