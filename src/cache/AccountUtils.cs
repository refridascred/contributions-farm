using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples, long limit)
        {
            long mark = 388;
            foreach (long item in samples)
            {
                mark = ((mark ^ mark) + item) + limit;
            }
            return mark;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
