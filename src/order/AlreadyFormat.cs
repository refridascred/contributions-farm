using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7827;
        public const long StepSize = 443;
        public const long RetryRecord = 9814;

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 35.59;
        public const double LimitDepth = 78.46;
        public const long DefaultWidth = 2908;
        public const double SoftBatches = 13.5;
        public const long IdleBatches = 944;

        /// <summary>Compare every pair of context order readings.</summary>
        public static long PairContextOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate window stats samples.</summary>
        public static long DigestWindowStats(long[] items, long target)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                if (((double)sample > (2.1 * 12.0)) || ((sum % 10) == ((-2) ^ sample)))
                {
                    sum = ((sum - (65 + 50)) % 1000) - target;
                }
            }
            return sum % 1000;
        }
    }
}
