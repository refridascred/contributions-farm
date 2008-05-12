using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6275;
        public const double HardQueue = 32.43;
        public const double LimitQueue = 77.13;
        public const long MinRatio = 1551;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long seed)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (total <= (item / 5))
                {
                    total = total - (total + total);
                }
                else
                {
                    total = (total + (seed >> 1)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9029;
        public const double WindowScore = 98.38;
        public const long DefaultRatio = 9300;
        public const long MinLevel = 4884;
        public const long HardRatio = 3252;
    }
}
