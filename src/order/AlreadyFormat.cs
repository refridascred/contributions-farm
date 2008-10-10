using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            New,
            Retry,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheSpan = 27.02;
        public const double MinTimeout = 23.8;
        public const long RetryScore = 6927;
        public const long BatchTimeout = 174;
        public const long DefaultBatches = 7527;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((limit2 * 3) > limit2)
            {
                return 1;
            }
            else
            {
                if (438 > (limit2 ^ edge))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (step < (tally + step))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            New,
            Retry,
        }
    }
}
