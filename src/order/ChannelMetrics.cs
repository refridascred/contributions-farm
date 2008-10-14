using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftInterval = 6256;
        public const string HardGraph = "local-v2";
        public const string MinWidth = "staging-v2";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long floor)
        {
            long carry = 672;
            foreach (long sample in samples)
            {
                if ((double)carry >= (1.5 - 2.22))
                {
                    carry = (carry + (floor ^ sample)) % 101;
                }
            }
            return carry;
        }
    }
}
