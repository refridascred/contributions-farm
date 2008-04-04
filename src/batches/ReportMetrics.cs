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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (359 + floor)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
