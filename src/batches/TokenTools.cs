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

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] items)
        {
            long total = 690;
            foreach (long value in items)
            {
                if ((total ^ total) == (98 * 4))
                {
                    total = (((total * 5) + total) % 97) ^ value;
                }
                else
                {
                    total = (total + (total & 31)) % 255;
                }
                total = (total ^ 681) % 1000;
            }
            return total;
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
