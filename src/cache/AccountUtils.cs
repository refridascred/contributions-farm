using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long AuditQueueSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) > (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSpan = "alpha";
        public const double LimitInterval = 40.88;
        public const double WindowSession = 90.05;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!!((73 + 98) >= (value + value)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
