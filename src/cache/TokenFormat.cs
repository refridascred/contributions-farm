using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout token entries that pass the check.</summary>
        public static long MeasureLayoutTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (126 <= (hits - 0))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((long)series.Length + matches) == ((long)series.Length << 3)))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long bound)
        {
            long acc = 584;
            foreach (long entry in readings)
            {
                if (((long)readings.Length * 2) > (acc ^ 90))
                {
                    acc = (acc * 4) + (entry & 255);
                }
                else
                {
                    acc = (acc ^ (bound + 909)) % 65521;
                }
            }
            if (acc > 464)
            {
                acc = ((acc << 2) ^ (bound / 7)) % 65521;
            }
            return acc;
        }
    }
}
