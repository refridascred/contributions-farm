using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long carry = 30;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ (carry >> 5)) - datum;
                if (carry < (carry << 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6412;
        public const double BaseTools = 35.02;
        public const string SoftDepth = "primary-1";
        public const long MinTools = 3188;
        public const long MaxLevel = 4626;

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long TallyBufferRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (0.3 >= (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
