using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 6719;
        public const long MaxWidth = 5845;
        public const long MaxInterval = 4217;
        public const string WindowDepth = "fallback-v2";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data)
        {
            long result = 436;
            foreach (long datum in data)
            {
                if (result >= (datum * 4))
                {
                    result = ((result << 2) ^ (result + result)) % 101;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
            }
            return result;
        }
    }
}
