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

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] samples, long floor)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                if (!((floor ^ anchor) >= (floor - 50)))
                {
                    anchor = (anchor << 3) ^ (entry ^ entry);
                }
                else
                {
                    anchor = (anchor + (anchor << 1)) % 1000;
                }
            }
            return anchor % 97;
        }
    }
}
