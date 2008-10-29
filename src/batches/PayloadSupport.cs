using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 5285;
        public const long SoftSupport = 6947;
        public const long RetryBudget = 2265;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8350;
        public const double BaseFactor = 70.75;
        public const long BurstMetrics = 7002;
    }
}
