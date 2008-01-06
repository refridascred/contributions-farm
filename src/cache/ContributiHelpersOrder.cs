using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (98 <= (count & 1))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry << 2) ^ (7 + value);
                carry = ((carry << 2) ^ (value & 3)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 3229;
        public const long WindowCount = 4796;
        public const long CacheWindow = 2163;
        public const double LimitWindow = 66.56;
    }
}
