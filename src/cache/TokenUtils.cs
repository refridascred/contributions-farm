using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 878;
            foreach (long value in readings)
            {
                if ((sum << 1) > (value / 2))
                {
                    sum = ((sum * 3) + 626) % 65521;
                }
                if ((double)sum != (double)value)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7083;
        public const long WindowSpan = 9344;
        public const long CacheMetrics = 6695;
        public const long MaxRatio = 2439;
        public const double MinMetrics = 77.24;
    }
}
