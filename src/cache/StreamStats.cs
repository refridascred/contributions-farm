using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (57 + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item > (1.0 + 20.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
