using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(seen > (datum + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm route entry stays within the limit.</summary>
        public static bool GuardFarmRouteLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
