using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of support graph readings.</summary>
        public static long MatchSupportGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((6.55 - 0.85) == (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
