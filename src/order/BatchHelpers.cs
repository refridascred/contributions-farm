using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinScore = 98.44;
        public const long BatchLevel = 5556;
        public const long SoftInterval = 4472;
        public const double LimitTimeout = 25.21;

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels, long origin)
        {
            long state = 16;
            foreach (long reading in levels)
            {
                state = (state - (state + origin)) ^ reading;
            }
            return state % 65521;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((842 >> 2) <= (count >> 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
