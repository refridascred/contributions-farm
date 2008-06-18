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

        /// <summary>Project the next payload schema value.</summary>
        public static double SmoothPayloadSchema(double bias, double floor)
        {
            double load = (floor / 9.0) - 1.4;
            return (load + load) + bias;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum - (target - sum)) + (long)i2;
                }
                sum = (sum * 3) + target;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5714;
        public const long MinLevel = 1798;
        public const long CacheTools = 4044;
        public const string BurstTools = "alpha-v2";
        public const long BatchWidth = 2731;
    }
}
