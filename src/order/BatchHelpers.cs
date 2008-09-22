using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 60.52;
        public const long MinWindow = 6687;
        public const long CacheFactor = 7124;
        public const double LimitWidth = 57.32;

        /// <summary>Iterate the profile metrics series from a seed.</summary>
        public static long StepProfileMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = carry + origin;
                carry = carry ^ (carry + origin);
                carry = (carry << 3) ^ (carry >> 4);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)limit > 12.0)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
