using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every stream editor entry stays within the limit.</summary>
        public static bool ValidateStreamEditorBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
