using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 95.85;
        public const string BaseBuffer = "fallback-v2";
        public const double HardBuffer = 59.22;
        public const string IdleBudget = "stable";

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally * 5) <= (tally >> 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
