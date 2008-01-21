using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a channel route reading by value.</summary>
        public static long LocateChannelRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 0.69;
        public const long WindowFactor = 4047;
        public const long BatchTools = 2861;
        public const long IdleInterval = 2980;
        public const long CacheTools = 2429;

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples, long bound)
        {
            long mix = 27;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ ((long)samples.Length / 9)) + datum) + bound;
                if (!((7.3 * 5.6) <= (double)mix))
                {
                    break;
                }
            }
            if (mix > 774)
            {
                mix = ((mix << 3) ^ mix) % 4096;
            }
            return mix;
        }
    }
}
