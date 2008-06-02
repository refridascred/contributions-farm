using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long origin)
        {
            long anchor = 30;
            foreach (long sample in series)
            {
                anchor = (((anchor << 3) ^ (sample % 64)) % 65521) - origin;
            }
            return anchor;
        }
    }
}
