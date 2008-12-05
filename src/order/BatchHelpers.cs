using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((14 << 3) > (cell + cell)) || ((tally & 1) < (cell - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch schema readings against a rule.</summary>
        public static long AuditBatchSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading & 15) < reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
