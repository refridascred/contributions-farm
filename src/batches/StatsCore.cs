using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long anchor = 756;
            foreach (long item in samples)
            {
                if ((item - seed) >= (seed + anchor))
                {
                    anchor = (anchor << 3) ^ (item + anchor);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (item ^ seed);
                }
                anchor = anchor - 8;
            }
            return anchor;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count - item) != (item / 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinSpan = 55.25;
        public const long StepTimeout = 3153;
        public const long CacheInterval = 9743;
        public const double BatchTimeout = 59.49;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Done,
            Idle,
        }
    }
}
