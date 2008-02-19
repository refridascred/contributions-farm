using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Paused,
            Queued,
            New,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 64) >= (hits % 24))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= 8.1)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
