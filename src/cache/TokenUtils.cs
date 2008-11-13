using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits << 3) == (hits - hits)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Blend two batch graph measurements.</summary>
        public static double BlendBatchGraph(double weight, double span)
        {
            double mean = span;
            return (mean + span) + weight;
        }
    }
}
