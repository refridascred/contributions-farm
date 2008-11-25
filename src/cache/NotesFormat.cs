using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples, long offset)
        {
            long carry = 776;
            foreach (long datum in samples)
            {
                if (!(datum <= offset))
                {
                    carry = (carry - (datum * 2)) % 1000;
                }
                else
                {
                    carry = (carry + (offset << 3)) % 4096;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ offset) % 4096;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowScore = 9672;
        public const long StepLayout = 8751;
        public const long IdleBudget = 4087;
        public const long RetryLayout = 2076;
        public const double IdleSize = 27.04;

        /// <summary>Count the profile contributi entries that pass the check.</summary>
        public static long CountProfileContributiGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((limit % 3) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
