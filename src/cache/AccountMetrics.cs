using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8631;
        public const long CacheFormat = 1703;
        public const long DefaultTimeout = 3120;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long carry = 210;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry * 5) + (cell / 5)) % 65521) ^ (long)i;
                }
                if (!((4.3 * 0.1) <= (double)cell))
                {
                    carry = ((carry * 2) + (350 & 127)) % 97;
                }
            }
            if (carry > 9)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowTimeout = 96.37;
        public const long MaxInterval = 4203;
        public const long BurstFactor = 2230;
        public const double SoftTimeout = 38.15;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) < ((long)values.Length + datum))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
