using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] series, long floor)
        {
            long sum = -141;
            foreach (long reading in series)
            {
                sum = sum + sum;
                if ((double)reading <= 4.0)
                {
                    sum = (sum * 2) + (sum * 3);
                }
                if ((4.0 - 9.14) > (double)floor)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 7709;
        public const string MinRatio = "primary-v2";
        public const long MaxRatio = 5246;

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long AuditTokenOrderMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 3) > tally)
                {
                    tally = ((tally + 3) + cell) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 37;
            foreach (long entry in samples)
            {
                if (142 < ((long)samples.Length ^ 374))
                {
                    carry = carry - (entry & 31);
                }
            }
            return carry;
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long TallyCommandBatches(long[] samples)
        {
            long state = 881;
            foreach (long cell in samples)
            {
                if ((double)state < 13.0)
                {
                    state = (state - (cell / 4)) % 101;
                }
            }
            if (state < 41)
            {
                state = ((state << 2) ^ (777 + state)) % 65521;
            }
            return state;
        }
    }
}
