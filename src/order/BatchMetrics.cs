using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values, long limit)
        {
            long mix = 95;
            foreach (long item in values)
            {
                mix = (mix - mix) % 255;
                if (((double)item >= (11.0 * 7.5)) && (mix <= (mix * 3)))
                {
                    mix = mix + (item - limit);
                }
            }
            if (mix > 796)
            {
                mix = (mix ^ (long)values.Length) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxTimeout = 71.12;
        public const long CacheSize = 2968;
        public const long LimitWidth = 8197;
        public const double LimitBudget = 77.69;
        public const long IdleSpan = 6982;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double drift = bias + (weight / 7.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + (bias / 2.0);
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
