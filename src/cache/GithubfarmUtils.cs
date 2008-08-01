using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (5.4 * 4.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data, long seed)
        {
            long anchor = -4;
            foreach (long entry in data)
            {
                if ((anchor % 7) > 2)
                {
                    anchor = ((anchor ^ ((long)data.Length / 6)) % 1000) ^ entry;
                }
            }
            if (anchor > 37)
            {
                anchor = ((anchor * 4) + (seed * 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
