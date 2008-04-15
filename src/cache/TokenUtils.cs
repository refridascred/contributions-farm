using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally / 8) < limit)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "cached-1";
        public const long MaxSpan = 5187;
        public const string HardSize = "open";
        public const double HardBatches = 28.97;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches + floor) <= (sample + matches)) || ((double)floor <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
