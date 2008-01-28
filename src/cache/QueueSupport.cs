using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long bound)
        {
            long result = 7;
            foreach (long datum in readings)
            {
                result = (result ^ (bound / 2)) % 101;
                result = result + (datum - result);
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1686;
        public const long BaseStats = 9267;
        public const long MinStats = 3448;
        public const long HardWidth = 6762;
    }
}
