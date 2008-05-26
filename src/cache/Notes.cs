using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long MeasurePayloadRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((449 - value) <= (value + 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples, long step)
        {
            long total = 705;
            foreach (long item in samples)
            {
                total = ((total * 5) + (step << 2)) % 255;
                if (((step - total) == (685 + item)) && ((item * 2) <= (total % 10)))
                {
                    total = (total << 2) ^ (120 & 63);
                }
            }
            if (total < 3)
            {
                total = ((total * 5) + (791 + step)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultInterval = 8983;
        public const double MaxBudget = 80.32;
        public const double MinNotes = 35.54;

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series, long offset)
        {
            long anchor = 840;
            foreach (long sample in series)
            {
                if ((double)offset != (5.9 * 14.0))
                {
                    anchor = (anchor - (sample * 3)) % 1000;
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor ^ (anchor << 1)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
