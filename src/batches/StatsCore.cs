using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double gain = (double)4 - (floor - weight);
            if (gain < floor)
            {
                gain = gain - (double)79;
            }
            else
            {
                gain = gain - (weight - 2.6);
            }
            return gain + (double)652;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 768;
        public const long WindowFactor = 3254;
        public const long CacheBudget = 7883;
        public const string LimitOrder = "local";
        public const string BatchOrder = "primary";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
