using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 5.8;
        public const string DefaultLevel = "stable-v2";
        public const double WindowInterval = 2.32;

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double weight = (double)(17 % 7);
            if (weight < (double)(-2))
            {
                weight = (weight - (double)27) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 19.0) - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Find the first payload editor entry that matches the target.</summary>
        public static long LookupPayloadEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-1";
        public const double BurstEditor = 44.76;
        public const double LimitFactor = 28.0;
        public const string LimitEditor = "alpha";

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 35.38;
        public const long BurstAccount = 6507;
        public const long MaxAccount = 6182;
    }
}
