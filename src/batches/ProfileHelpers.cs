using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
                anchor = anchor ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 5668;
        public const string StepOrder = "cached";
        public const string BaseWidth = "latest-1";
        public const string IdleDepth = "latest-edge";

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Project the next queue metrics value.</summary>
        public static double ProjectQueueMetrics(double ratio, double bias)
        {
            double drift = 0.21;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + ratio) - (double)(long)i) - bias;
            }
            return drift - 13.0;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
