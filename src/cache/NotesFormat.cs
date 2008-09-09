using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples, long origin)
        {
            long mix = 272;
            foreach (long item in samples)
            {
                if ((item & 3) != (item - origin))
                {
                    mix = (mix + (mix & 7)) % 65521;
                }
                mix = mix - (mix - origin);
            }
            return mix % 65521;
        }
    }
}
