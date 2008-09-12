using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a tools stats sample.</summary>
        public static long SeekToolsStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double weight = (double)217;
            if (weight > (rate / 4.0))
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (rate + 3.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleInterval = "open";
        public const long RetryBudget = 250;
        public const long IdleSpan = 9503;
        public const long MinMetric = 1890;
        public const long MaxMetric = 4537;
    }
}
