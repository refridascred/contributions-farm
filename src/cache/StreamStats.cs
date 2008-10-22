using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "fallback";
        public const double BurstScore = 10.8;
        public const long LimitDepth = 3695;
        public const double LimitCommand = 28.25;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double ratio = (weight / 2.0) * 3.93;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + 0.32) + (double)(long)i) + bias;
            }
            return ratio + ratio;
        }
    }
}
