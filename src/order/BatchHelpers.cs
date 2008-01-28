using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + matches) >= ((-11) & 63)) || ((matches - matches) >= (matches << 3))) && ((floor & 1) != (matches / 7)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (7.5 * 6.07))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (double)252)
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}
