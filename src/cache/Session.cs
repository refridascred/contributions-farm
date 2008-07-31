using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = result + (limit - result);
                result = (result - (95 ^ 1)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = acc - (item - acc);
            }
            if (acc < 7)
            {
                acc = acc - acc;
            }
            return acc % 65521;
        }

        /// <summary>Count the filter account entries that pass the check.</summary>
        public static long MeasureFilterAccountGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits > (4.54 - 7.4))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long TallyBufferBatchesGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count < (value + 9)) || ((count + (-97)) <= (count - 56))))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
