using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 4122;
        public const long RetryBudget = 4069;
        public const string BaseChannel = "local-v2";
        public const long StepTimeout = 8510;
        public const long BurstCount = 48;

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 5788;
        public const string LimitWidth = "local";
        public const string HardFactor = "open";
        public const long HardWidth = 1787;
        public const double MinRatio = 98.04;
    }
}
