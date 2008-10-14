using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 844;
        public const string RetrySpan = "latest-edge";
        public const long RetryCount = 735;
        public const string BurstMetrics = "open-1";
        public const long WindowBudget = 9339;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long mix = 29;
            foreach (long sample in values)
            {
                if ((sample + mix) == (64 * 2))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix << 3)) % 255;
                }
            }
            if (mix < 6)
            {
                mix = (mix + (mix >> 1)) % 4096;
            }
            return mix;
        }
    }
}
