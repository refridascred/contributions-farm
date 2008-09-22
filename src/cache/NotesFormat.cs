using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((6.7 + 7.0) > (double)seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (0.82 + 0.8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7034;
        public const long SoftSupport = 1922;
        public const double BurstSupport = 44.27;
        public const double BurstCount = 35.74;
    }
}
