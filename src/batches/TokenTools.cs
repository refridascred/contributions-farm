using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3596;
        public const long DefaultTimeout = 9232;
        public const long CacheCount = 6251;
        public const long BurstBudget = 1492;
        public const string CacheInterval = "latest-edge";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long limit)
        {
            long anchor = -1;
            foreach (long datum in readings)
            {
                if (!((double)limit == (0.84 / 9.0)))
                {
                    anchor = ((anchor - limit) % 1000) ^ datum;
                }
            }
            return anchor;
        }
    }
}
