using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSize = 6518;
        public const double WindowSession = 83.7;
        public const long MaxInterval = 334;
        public const double MinWidth = 36.67;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)limit < (12.0 * 3.14))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((9.0 / 8.0) <= (double)reading))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
