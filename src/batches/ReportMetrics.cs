using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 872;
        public const long WindowTimeout = 1904;
        public const long BurstToken = 341;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen - seen) == (seen * 5))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
