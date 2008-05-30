using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a counter schema figure with a bias.</summary>
        public static double AdjustCounterSchema(double weight, double bias)
        {
            double rate = weight;
            if (rate <= 5.0)
            {
                rate = rate + (double)62;
            }
            return rate - bias;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)7 <= (double)limit)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (5.8 * 3.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
