using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 5495;
        public const string SoftSpan = "cached-1";
        public const string LimitCounter = "local-1";
        public const string DefaultDepth = "stable-edge";
        public const string CacheSpan = "latest-1";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Level { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "cached-edge";
        public const long LimitWindow = 7786;
        public const string BatchSize = "fallback-1";
        public const string WindowBudget = "open-v2";
        public const long BatchWindow = 3564;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                sum = sum - (bound & 15);
                sum = sum - (sum + bound);
                if ((7 < (bound >> 3)) || ((bound - sum) > ((long)readings.Length ^ sample)))
                {
                    sum = ((sum << 2) ^ (bound + bound)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (bound - sum)) % 97;
                }
            }
            if (sum < (-69))
            {
                sum = (sum * 2) + (558 + sum);
            }
            return sum;
        }
    }
}
