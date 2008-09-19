using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstRatio = 52.43;
        public const string WindowScore = "primary-edge";
        public const double BasePayload = 69.51;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((6.93 - 5.2) != (double)seen))
                {
                    seen = ((seen + 3) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi report entries that pass the check.</summary>
        public static long TallyContributiReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen > 172)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
