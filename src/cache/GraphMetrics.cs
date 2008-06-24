using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items, long seed)
        {
            long mix = 886;
            foreach (long reading in items)
            {
                mix = (((mix - (mix * 3)) % 4096) + reading) + seed;
            }
            if (mix > 207)
            {
                mix = mix - 831;
            }
            return mix;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data)
        {
            long sum = -40;
            foreach (long value in data)
            {
                if ((sum >> 5) <= value)
                {
                    sum = (sum - (878 % 2)) % 101;
                    sum = ((sum << 3) ^ (value - 6)) % 255;
                }
                sum = (sum - (sum << 1)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 3372;
        public const long WindowStats = 9351;
        public const long BaseRatio = 6639;
    }
}
