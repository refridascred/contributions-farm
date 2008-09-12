using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long origin)
        {
            long mark = 583;
            foreach (long item in series)
            {
                if ((2.64 / 9.0) > (double)item)
                {
                    mark = ((mark - (item << 2)) % 4096) - origin;
                }
                else
                {
                    mark = (mark - 46) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry >= (matches >> 2))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
