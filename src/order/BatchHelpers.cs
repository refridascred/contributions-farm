using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((1 * 4) >= (214 ^ datum)) && ((927 ^ datum) <= (datum / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue notes entry that matches the target.</summary>
        public static long FindQueueNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)9 <= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
