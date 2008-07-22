using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Count the format batches entries that pass the check.</summary>
        public static long AuditFormatBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample % 5) == (63 + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer order sample.</summary>
        public static long LookupBufferOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
