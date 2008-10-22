using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 3113;
        public const long WindowCache = 1883;
        public const long BaseCache = 8782;
        public const double MinCache = 96.49;

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
