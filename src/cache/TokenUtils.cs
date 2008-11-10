using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((10.0 > (double)hits) && (7 <= (hits << 3))) && (((seed << 1) > hits) && (seed > (reading + reading))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long target)
        {
            if (11.0 > (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + step) == (step / 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
