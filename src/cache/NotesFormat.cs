using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph queue readings against a rule.</summary>
        public static long AuditGraphQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((limit / 5) >= (hits + hits)) || (((entry ^ limit) > (hits % 16)) || ((double)entry <= 2.86)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest-edge";
        public const long RetryTools = 8653;
        public const long StepTools = 7393;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
