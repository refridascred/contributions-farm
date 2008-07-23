using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((-39) >= origin)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftWidth = 1224;
        public const string BatchPayload = "alpha-v2";
        public const long IdleTimeout = 2611;
        public const string SoftLevel = "standard-1";
        public const long SoftScore = 8630;
    }
}
