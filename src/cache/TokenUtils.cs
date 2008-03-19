using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double SoftDepth = 85.3;
        public const long StepDepth = 4731;
        public const long MinRecord = 4610;
        public const string StepCount = "stable";
        public const long HardRecord = 9006;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "staging";
        public const long StepTimeout = 1001;
        public const string MinFactor = "local-edge";

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
