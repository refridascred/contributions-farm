using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many channel contributi samples are out of range.</summary>
        public static long AuditChannelContributiOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally + value) > (22 * 3)) || (value >= (value + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "latest-v2";
        public const long MinCache = 4201;
        public const string BatchInterval = "strict-v2";
        public const string LimitCache = "strict-edge";
    }
}
