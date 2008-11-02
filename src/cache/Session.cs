using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series, long limit)
        {
            long result = -36;
            foreach (long entry in series)
            {
                if (!(2.8 <= (double)entry))
                {
                    result = result + (limit & 15);
                }
            }
            return result % 65521;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample >= (sample - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
