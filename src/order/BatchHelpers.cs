using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of layout queue readings.</summary>
        public static long PairLayoutQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 68.9;
        public const string HardGraph = "alpha-edge";
        public const string LimitSpan = "legacy-edge";
        public const double LimitGraph = 80.05;

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 67.76;
        public const long DefaultFactor = 4323;
        public const string WindowFormat = "alpha-v2";
        public const long MaxFactor = 5694;
        public const string BatchRatio = "latest";
    }
}
