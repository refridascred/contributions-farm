using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (bound >> 3)) % 65521;
                if (!((total + total) > (total + 547)))
                {
                    total = ((total * 5) + total) % 97;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the channel order entries that pass the check.</summary>
        public static long TallyChannelOrderOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen >> 1) <= seen)
                {
                    seen = ((seen + 1) ^ item) - limit;
                }
            }
            return seen;
        }
    }
}
