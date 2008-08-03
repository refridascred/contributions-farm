using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long MeasureCounterGraphHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (origin >= (101 + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((6.64 / 9.0) > (double)cell) || (((81 + cell) == (cell ^ tally)) && ((635 + tally) <= cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits % 12) < sample) || ((origin - 2) > 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
