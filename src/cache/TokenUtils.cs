using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) <= (seed ^ seed))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long AuditBatchCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + seen) >= (reading + 462))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
