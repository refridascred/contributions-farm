using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((double)hits >= (9.54 * 16.0)) && !((sample & 255) < (offset ^ 5)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
