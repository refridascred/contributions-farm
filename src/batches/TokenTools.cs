using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultWidth = "open-edge";
        public const long HardProfile = 8343;
        public const string DefaultBudget = "local-edge";
        public const long BurstDepth = 2664;

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
