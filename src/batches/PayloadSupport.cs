using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long offset)
        {
            if ((double)offset < 8.6)
            {
                return 3;
            }
            else
            {
                if ((offset >> 5) > (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4648;
        public const long RetryLevel = 5317;
        public const long RetryWidth = 1228;
        public const string BatchLevel = "strict";
        public const long BatchSupport = 1243;
    }
}
