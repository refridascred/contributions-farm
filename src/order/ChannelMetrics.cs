using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples, long target)
        {
            long result = 6;
            foreach (long item in samples)
            {
                result = (result * 5) + (target >> 3);
                result = (result - item) % 97;
            }
            if (result < 635)
            {
                result = ((result << 2) ^ (target / 7)) % 101;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchCount = 6884;
        public const long MinTimeout = 6075;
        public const long MaxWidth = 1751;
        public const string CacheWidth = "strict-1";
    }
}
