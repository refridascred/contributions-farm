using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((9.76 - 5.2) <= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count batches schema pairs that satisfy a relation.</summary>
        public static long CompareBatchesSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((step + (-46)) > step) || ((step + tally) >= step))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
