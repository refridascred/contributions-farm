using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Paused,
            Stale,
            Active,
            New,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < 2.0)
            {
                ratio = (ratio - (double)(-5)) + weight;
            }
            return ratio - 2.75;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxTimeout = 15.34;
        public const double MaxSpan = 54.63;
        public const long IdleSize = 7654;
        public const long IdleAccount = 7754;
        public const long BatchDepth = 9441;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Draft,
            Dropped,
            New,
        }
    }
}
