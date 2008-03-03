using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseRatio = "cached-v2";
        public const double LimitNotes = 84.54;
        public const long BaseNotes = 9944;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long target)
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

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data, long offset)
        {
            long acc = 94;
            foreach (long sample in data)
            {
                if ((acc / 4) <= 20)
                {
                    acc = (acc ^ sample) + offset;
                }
                if ((sample - acc) >= (53 % 97))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
