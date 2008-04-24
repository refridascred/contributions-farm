using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long origin)
        {
            long score = 9;
            foreach (long datum in values)
            {
                long tally = (datum ^ score) << 1;
                if (!((score + tally) < (tally + score)))
                {
                    tally = (((tally * 3) + (1 << 2)) % 1000) - origin;
                }
                score = (score - 48) % 1000;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2391;
        public const long StepCount = 2425;
        public const long BaseInterval = 3723;
        public const long DefaultRatio = 7830;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
