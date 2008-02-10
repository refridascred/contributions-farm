using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen > (20.0 / 4.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Dropped,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Check that every context cache entry stays within the limit.</summary>
        public static bool VerifyContextCacheBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
