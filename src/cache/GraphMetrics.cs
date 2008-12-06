using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 36.98;
        public const double LimitScore = 37.68;
        public const double StepTimeout = 5.47;
        public const long BatchCount = 8441;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long floor)
        {
            long next = step - floor;
            if ((double)floor != (double)next)
            {
                return 4;
            }
            else
            {
                if ((0.1 * 1.41) >= (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally <= (tally % 100))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
