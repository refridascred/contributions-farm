using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 6868;
        public const double IdleFilter = 56.51;
        public const long CacheFilter = 9898;
        public const string BatchScore = "open-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleFactor = 59.53;
        public const long BaseCommits = 6133;
        public const double SoftCommits = 86.05;
        public const long DefaultCommits = 894;
        public const long CacheScore = 1789;

        /// <summary>Measure how many stream cluster samples are out of range.</summary>
        public static long AuditStreamClusterMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((676 % 16) <= (step & 15))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }
    }
}
