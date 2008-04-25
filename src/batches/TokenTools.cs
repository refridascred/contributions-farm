using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Failed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((offset / 7) == (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 1) < (entry * 2))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
