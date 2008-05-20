using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ datum) > (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a filter schema reading by value.</summary>
        public static long LocateFilterSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics cluster readings against a rule.</summary>
        public static long AuditMetricsClusterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - 9) > count)
                {
                    count = ((count + 2) ^ item) + offset;
                }
            }
            return count;
        }
    }
}
