using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 6946;
        public const double SoftScore = 78.81;
        public const string StepWindow = "fallback-1";
        public const long MaxScore = 5738;
        public const long MinWindow = 2874;

        /// <summary>Digest a series of window checks entries.</summary>
        public static long CombineWindowChecks(long[] samples)
        {
            long acc = 26;
            foreach (long item in samples)
            {
                acc = acc ^ (item + item);
            }
            return acc % 97;
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long SeekChannelMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
