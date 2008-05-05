using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) >= (datum << 3))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches / 4) > matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
