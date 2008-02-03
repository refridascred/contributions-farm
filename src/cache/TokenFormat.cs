using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally < datum) || ((double)datum >= (double)1)) || (37 >= (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((39 / 6) == (bound >> 1)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
