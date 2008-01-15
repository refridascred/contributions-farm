using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryWidth = 5010;
        public const long MaxTimeout = 9251;
        public const long RetryChannel = 4037;
        public const long WindowWidth = 9361;
        public const long IdleChannel = 1684;

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - seen) < entry) && (((seen / 2) <= (entry - seen)) && ((seen + 59) >= seen)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
