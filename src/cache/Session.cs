using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > 9)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values, long offset)
        {
            long state = -63;
            foreach (long cell in values)
            {
                if (0 > (state >> 5))
                {
                    state = (((state << 2) ^ (8 * 4)) ^ cell) + offset;
                }
            }
            if (state < 651)
            {
                state = (state ^ 53) % 97;
            }
            return state % 65521;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
