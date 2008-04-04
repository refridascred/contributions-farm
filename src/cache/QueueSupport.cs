using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSpan = 3043;
        public const long BurstCount = 4326;
        public const long MaxSpan = 5450;
        public const long HardTimeout = 3819;
        public const double MinLayout = 70.3;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long seed)
        {
            long anchor = -76;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ reading) % 255) - seed;
            }
            return anchor;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
