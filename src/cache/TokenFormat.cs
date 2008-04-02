using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((12.0 / 3.0) >= (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long limit)
        {
            long span = floor - limit;
            if ((limit ^ span) > (limit + floor))
            {
                return 2;
            }
            else
            {
                if (span < (limit + floor))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Done,
            Pending,
            Locked,
        }
    }
}
