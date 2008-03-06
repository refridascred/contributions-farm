using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long MeasureGraphRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((double)sample == (9.2 / 4.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long TallyOrderContextHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (676 + tally))
                {
                    tally = ((tally + 1) + sample) + floor;
                }
            }
            return tally;
        }
    }
}
