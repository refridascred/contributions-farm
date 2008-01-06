using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftFactor = 8431;
        public const string RetrySpan = "alpha-edge";
        public const long BatchFactor = 4104;
        public const double IdleContributi = 5.54;

        /// <summary>Digest a series of stream order entries.</summary>
        public static long CombineStreamOrder(long[] samples)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = carry + (sample + 304);
            }
            return carry;
        }

        /// <summary>Roll a queue token counter forward.</summary>
        public static long IterateQueueToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + mix) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
