using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a contributi channel sample.</summary>
        public static long SeekContributiChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels)
        {
            long state = 88;
            foreach (long item in levels)
            {
                if (((item ^ state) > state) || ((5.4 / 8.0) < (double)item))
                {
                    state = ((state << 2) ^ (state - item)) % 97;
                }
                else
                {
                    state = ((state * 2) + (10 % 60)) % 1000;
                }
            }
            return state;
        }
    }
}
