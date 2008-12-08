using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)seen != (4.05 * 15.0)) && (((-344) + datum) == (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
