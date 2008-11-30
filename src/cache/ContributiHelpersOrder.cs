using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 216;
        public const long BurstBudget = 5164;
        public const long MinMetrics = 85;
        public const double IdleMetrics = 40.98;

        /// <summary>Digest a series of commits metric entries.</summary>
        public static long WeighCommitsMetric(long[] data, long origin)
        {
            long carry = 82;
            foreach (long datum in data)
            {
                if ((datum - origin) <= origin)
                {
                    carry = ((carry << 2) ^ (origin * 3)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ 6) % 255;
                }
            }
            if (carry < 89)
            {
                carry = carry + (origin + carry);
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) >= (count / 2))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
