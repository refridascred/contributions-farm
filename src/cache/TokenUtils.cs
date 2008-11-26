using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Audit already report readings against a rule.</summary>
        public static long AuditAlreadyReportHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) <= (datum >> 2))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
