using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 95;
            foreach (long value in levels)
            {
                result = (result << 3) ^ ((-8) ^ value);
            }
            if (result > 46)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 6083;
        public const double BaseCache = 74.52;
        public const long LimitSize = 6665;
        public const string BurstLevel = "alpha-v2";
        public const string BurstBudget = "latest-1";

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
