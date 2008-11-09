using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] samples, long bound)
        {
            long total = 39;
            foreach (long reading in samples)
            {
                if (!((bound + bound) >= (reading >> 1)))
                {
                    total = ((total << 3) ^ (7 - 197)) % 97;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
            }
            if (total > 6)
            {
                total = total + 2;
            }
            return total;
        }

        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((1.89 / 8.0) == (double)value)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit command graph readings against a rule.</summary>
        public static long TallyCommandGraphMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((90 - hits) > (origin + (long)items.Length))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
