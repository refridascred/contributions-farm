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

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
