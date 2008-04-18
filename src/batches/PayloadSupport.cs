using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 2176;
        public const string MaxWidth = "fallback-edge";
        public const long CacheAccount = 1639;
        public const long BurstInterval = 3350;

        /// <summary>Adjust a buffer payload reading.</summary>
        public static double BlendBufferPayload(double gain, double offset)
        {
            double gain2 = gain * 9.95;
            if (gain2 > offset)
            {
                gain2 = gain2 + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + (double)39) + (double)(long)i;
            }
            return gain2 + (double)47;
        }
    }
}
