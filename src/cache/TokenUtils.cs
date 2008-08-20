using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading >= seen)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long AuditOrderReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits % 3) > (hits % 16)) || ((hits * 4) > hits))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item ^ seen) >= (56 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
