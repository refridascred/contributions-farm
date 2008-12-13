using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum - seen) >= (datum + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "primary";
        public const string DefaultPayload = "legacy";
        public const long CacheLevel = 51;
        public const long MaxPayload = 1537;
        public const double BatchPayload = 48.57;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((-89) >= (count & 1))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
