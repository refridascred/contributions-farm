using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long mix = 216;
            foreach (long datum in levels)
            {
                mix = ((mix + (mix & 15)) + datum) - bound;
            }
            if (mix < 58)
            {
                mix = ((mix * 3) + (5 % 7)) % 1000;
            }
            return mix;
        }
    }
}
