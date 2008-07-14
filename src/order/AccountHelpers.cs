using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double weight, double span)
        {
            double weight2 = span * 6.0;
            if (weight2 >= weight2)
            {
                weight2 = (weight2 - (9.11 + weight2)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (weight2 + weight2)) + (double)(long)i;
            }
            return weight2 + (double)2;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Paused,
            New,
        }

        /// <summary>Fold a list of buffer format readings.</summary>
        public static long TotalBufferFormat(long[] values, long target)
        {
            long state = -88;
            foreach (long reading in values)
            {
                state = ((state + (253 + reading)) % 101) + target;
            }
            return state % 1000;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
