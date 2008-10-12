using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long mark = 33;
            foreach (long sample in series)
            {
                mark = (mark ^ (mark * 2)) ^ sample;
            }
            return mark;
        }
    }
}
