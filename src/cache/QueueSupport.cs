using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardCount = 4.38;
        public const long HardSupport = 5765;
        public const long LimitSupport = 1101;
        public const long SoftSpan = 3275;

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstScore = 96.1;
        public const long BatchRecord = 8488;
        public const string BaseRatio = "open";
        public const long StepScore = 6813;
        public const long BurstRecord = 6864;
    }
}
