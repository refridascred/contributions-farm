using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen - datum) != (datum - datum)) && ((0.84 <= (double)seen) || ((double)seed != (4.0 / 3.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) > (entry + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
