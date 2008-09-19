using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data)
        {
            long mark = 567;
            foreach (long reading in data)
            {
                mark = mark ^ (reading + reading);
            }
            if (mark > 769)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 15.44;
        public const long MaxInterval = 6021;
        public const long LimitBudget = 9386;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed - (long)i) < (anchor >> 4))
                {
                    anchor = (anchor - seed) % 65521;
                    anchor = (anchor + (anchor ^ anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
