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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Failed,
            Paused,
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
