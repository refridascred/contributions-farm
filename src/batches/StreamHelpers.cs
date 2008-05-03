using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 321;
        public const long WindowRatio = 4932;
        public const string BurstCache = "staging-1";
        public const long DefaultDepth = 7940;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 1441;
        public const double MinBudget = 3.77;
        public const long BatchSpan = 3695;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long target, long floor)
        {
            if ((target << 3) >= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= 5.04)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (5 + value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Stale,
            New,
            Failed,
        }
    }
}
