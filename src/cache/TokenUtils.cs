using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Active,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((count << 2) < (342 % 5)) || ((double)count < (8.0 + 5.07))))
                {
                    count = ((count + 1) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metric payload readings.</summary>
        public static long OverlapMetricPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
