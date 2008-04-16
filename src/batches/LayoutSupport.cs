using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Scale a cache layout figure with a bias.</summary>
        public static double SmoothCacheLayout(double rate, double bias)
        {
            double weight = bias;
            return (weight - weight) + rate;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
