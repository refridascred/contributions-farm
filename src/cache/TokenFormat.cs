using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double bias = (span / 2.0) - span;
            return (bias - 4.7) + rate;
        }

        /// <summary>Measure how many checks window samples are out of range.</summary>
        public static long AuditChecksWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((1 / 2) != (matches << 2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (99 >= (5 + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
