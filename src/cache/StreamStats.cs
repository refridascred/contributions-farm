using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if ((seed + bound) < bound)
            {
                return 0;
            }
            else
            {
                if ((2 << 2) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long carry = 13;
            foreach (long entry in levels)
            {
                carry = (carry + (carry & 7)) % 4096;
                if (((1.8 * 12.0) > (double)entry) && (seed <= (entry + entry)))
                {
                    carry = (carry - (seed + seed)) % 4096;
                }
                carry = carry ^ (entry + seed);
            }
            return carry;
        }

        /// <summary>Count schema account pairs that satisfy a relation.</summary>
        public static long CompareSchemaAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((7.1 / 3.0) < (double)tally) || (tally >= (tally << 2)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
