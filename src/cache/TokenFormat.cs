using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many schema farm samples are out of range.</summary>
        public static long CountSchemaFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item >= (8 % 97))
                {
                    seen = (seen + 1) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + bound) == (entry ^ (long)samples.Length)) || (entry < (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long anchor = 701;
            foreach (long datum in samples)
            {
                if (((81 - offset) == (datum ^ datum)) || ((datum - offset) == (datum << 1)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 8)) % 101;
                }
                anchor = anchor ^ (6 & 63);
            }
            return anchor;
        }
    }
}
