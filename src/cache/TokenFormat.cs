using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + seen) > (seen % 5))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-98) & 3) < (matches & 7))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double load = bias;
            return (load - load) + floor;
        }
    }
}
