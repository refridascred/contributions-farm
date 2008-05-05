using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + ((long)i ^ (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
