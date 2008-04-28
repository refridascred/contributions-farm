using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first graph queue entry that matches the target.</summary>
        public static long SeekGraphQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (double)(-42))
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio / 2.0)) + (double)(long)i;
            }
            return ratio + (double)(-8);
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftDepth = 3032;
        public const long CacheSize = 3553;
        public const long BatchWidth = 1830;
    }
}
