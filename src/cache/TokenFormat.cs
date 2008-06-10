using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftSize = 2795;
        public const double StepSpan = 10.76;
        public const string DefaultProfile = "primary-1";
        public const long SoftProfile = 6917;
        public const string CacheProfile = "staging-edge";

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) != ((long)series.Length >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-15) + count) <= step)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
