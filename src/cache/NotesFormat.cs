using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long RankTokenCache(long bound, long origin)
        {
            if (!(((-9) + origin) <= (bound + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin * 5) >= bound) || (((-8) + origin) <= 9))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 54) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (6.0 - 1.11))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
