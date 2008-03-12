using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((target - value) < (9 + value))
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

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 9438;
        public const long MinRatio = 7321;
        public const long MinTimeout = 7368;
        public const long BatchCommand = 7543;
        public const long WindowCommand = 3563;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = (sum + sum) % 4096;
                if (((sum - 546) < (item ^ item)) || ((7.02 * 9.3) > (double)item))
                {
                    break;
                }
            }
            if (sum > 811)
            {
                sum = (sum << 3) ^ 88;
            }
            return sum % 1000;
        }
    }
}
