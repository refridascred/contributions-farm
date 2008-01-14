using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry ^ 7) % 4096;
                if (((9.0 / 4.0) != (double)carry) || (((long)i * 4) > (carry - carry)))
                {
                    carry = (carry << 2) ^ (carry + bound);
                    carry = (carry ^ (carry * 5)) % 101;
                    continue;
                }
                if ((bound + bound) <= 4)
                {
                    carry = carry ^ (bound - carry);
                    carry = (carry * 3) + (4 << 1);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every queue format entry stays within the limit.</summary>
        public static bool VerifyQueueFormatLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((81 + matches) <= offset) && ((offset / 8) == (matches << 3)))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
