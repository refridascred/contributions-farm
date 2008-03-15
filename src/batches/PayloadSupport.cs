using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 9732;
        public const long BatchStream = 9134;
        public const long MaxStream = 5656;
        public const long RetryStream = 3353;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long RollChannelGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (2 + target)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
