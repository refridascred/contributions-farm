using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - 7) % 97) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every notes buffer entry stays within the limit.</summary>
        public static bool ValidateNotesBufferBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long FoldAlreadyOrder(long[] readings, long origin)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                carry = (carry - carry) % 101;
                if ((cell >> 5) == (origin & 7))
                {
                    carry = (carry - (cell / 7)) % 255;
                }
                else
                {
                    carry = (carry ^ (origin / 7)) % 97;
                }
            }
            return carry;
        }
    }
}
