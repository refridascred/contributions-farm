using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((4.0 / 6.0) >= (double)hits)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((779 + hits) > (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
