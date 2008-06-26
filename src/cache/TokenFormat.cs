using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepTimeout = 9.16;
        public const double BatchScore = 31.92;
        public const long BatchBatches = 6517;
        public const string BatchLevel = "latest-1";
        public const double BatchInterval = 76.09;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long offset)
        {
            long carry = 304;
            foreach (long entry in levels)
            {
                if ((offset / 6) > (carry % 10))
                {
                    carry = (carry - (53 + offset)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (entry - entry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally > (825 / 8))
                {
                    tally = ((tally + 3) ^ reading) + floor;
                }
            }
            return tally;
        }
    }
}
