using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 1866;
        public const double LimitWindow = 49.86;
        public const string IdleSize = "cached-edge";

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long CountMetricFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches % 12) > (datum - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }
    }
}
