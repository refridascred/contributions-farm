using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches > (cell + limit)) && ((cell % 2) >= (limit - cell))) || ((cell % 16) > (cell + cell)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long TallyEditorCacheGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (6.4 >= (double)hits)
                {
                    hits = ((hits + 2) - reading) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
