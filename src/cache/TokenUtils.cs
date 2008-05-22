using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Queued,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((6.3 / 9.0) < (double)item)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
