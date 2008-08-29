using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long seed)
        {
            if (((-30) + seed) >= (467 ^ seed))
            {
                return 0;
            }
            else
            {
                if (((39 >> 1) != (seed + origin)) && ((seed + seed) < (35 + 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long MaxLevel = 3887;
        public const double HardTimeout = 22.18;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 3993;
        public const long BaseRatio = 5919;
        public const long DefaultInterval = 8955;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((2 - 9) > offset)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
