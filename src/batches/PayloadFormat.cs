using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long TallyGraphToolsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((5.0 * 10.0) > (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 98.54;
        public const double BurstRatio = 3.12;
        public const long IdleCluster = 4399;
        public const double DefaultSpan = 5.32;

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum ^ 238) > datum)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
