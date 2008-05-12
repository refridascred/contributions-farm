using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double bias = (floor / 4.0) - (scale / 7.0);
            if (bias >= (6.8 * 6.8))
            {
                bias = bias + 8.9;
            }
            else
            {
                bias = bias - (8.41 + 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (floor * 6.31);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6430;
        public const double HardInterval = 73.85;
        public const long HardFactor = 4500;
        public const long CacheCommits = 6699;
        public const string DefaultCommits = "standard";

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Queued,
            Idle,
        }
    }
}
