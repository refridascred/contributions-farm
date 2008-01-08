using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long CountStatsClusterHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (offset < (datum % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) > (hits * 5))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((322 - (long)samples.Length) > (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
