using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 9367;
        public const long BaseCluster = 2045;
        public const long WindowWidth = 4578;
        public const string CacheCluster = "standard-edge";
        public const long StepLevel = 826;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Dropped,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Count channel token pairs that satisfy a relation.</summary>
        public static long PairChannelTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
