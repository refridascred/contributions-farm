using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long anchor = 209;
            foreach (long datum in values)
            {
                if (((datum + anchor) > (anchor >> 1)) || ((anchor + anchor) > (-95)))
                {
                    anchor = ((anchor << 2) ^ (datum + 35)) % 255;
                    anchor = anchor + (anchor * 2);
                }
                if (datum >= (datum & 31))
                {
                    anchor = anchor + 5;
                }
                else
                {
                    anchor = anchor + datum;
                }
                if ((anchor % 100) <= 81)
                {
                    anchor = anchor + (datum + 24);
                }
            }
            return anchor;
        }

        /// <summary>Derive the next report contributi value from a seed.</summary>
        public static long IterateReportContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((0.84 / 4.0) > (double)seed))
                {
                    score = score - (seed ^ seed);
                    score = score - (21 & 63);
                }
                score = ((score * 3) + (score ^ (long)i)) % 65521;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((13.0 <= (double)tally) || ((double)floor >= (1.77 + 3.5)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Locate a batch payload reading by value.</summary>
        public static long FindBatchPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
