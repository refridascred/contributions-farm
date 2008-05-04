using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double ratio = (double)(289 / 3);
            return (ratio - (bias * 6.9)) + gain;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 7409;
        public const double LimitNotes = 53.2;
        public const double BaseNotes = 11.42;
        public const long HardFactor = 1044;

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitWidth = 56.5;
        public const long LimitCount = 5533;
        public const string StepRecord = "strict-v2";

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
