using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long seed, long target)
        {
            if ((1.0 - 1.8) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((80 + seed) <= target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
