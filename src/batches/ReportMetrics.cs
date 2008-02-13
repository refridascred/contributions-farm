using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every checks notes entry stays within the limit.</summary>
        public static bool ValidateChecksNotesBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 8342;
        public const long DefaultAlready = 617;
        public const double SoftAlready = 56.31;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits ^ 925) > ((-6) & 31))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
