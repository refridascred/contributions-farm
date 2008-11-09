using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series)
        {
            long carry = 534;
            foreach (long datum in series)
            {
                if ((datum * 4) >= (datum + carry))
                {
                    carry = (carry << 3) ^ ((-339) << 2);
                }
                if ((17.0 * 0.9) >= (double)carry)
                {
                    carry = (carry ^ (datum ^ datum)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (datum - carry);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of window context readings.</summary>
        public static long FoldWindowContext(long[] samples, long bound)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if ((item % 64) < (bound ^ 857))
                {
                    result = ((result << 2) ^ (5 / 5)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 1830;
        public const long BurstBudget = 2272;
        public const long StepFactor = 9362;
        public const long WindowScore = 4454;
    }
}
