using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double StepSize = 36.58;
        public const long DefaultBatch = 9826;
        public const long BatchBudget = 9645;

        /// <summary>Audit buffer layout readings against a rule.</summary>
        public static long TallyBufferLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen <= 9.6)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
