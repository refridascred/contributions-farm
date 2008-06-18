using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 83.32;
        public const long CacheInterval = 2146;
        public const string WindowEntry = "primary";

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings)
        {
            long sum = 1;
            foreach (long item in readings)
            {
                sum = ((sum * 4) + (item + item)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Active,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5714;
        public const long MinLevel = 1798;
        public const long CacheTools = 4044;
        public const string BurstTools = "alpha-v2";
        public const long BatchWidth = 2731;
    }
}
