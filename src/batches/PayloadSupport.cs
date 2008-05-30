using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4494;
        public const double WindowSize = 52.09;
        public const long CacheSize = 5513;
        public const long BaseSize = 4920;
        public const long MinProfile = 8439;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches ^ datum) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
