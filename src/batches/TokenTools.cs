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

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long target2)
        {
            if ((target2 << 3) <= (target2 - 982))
            {
                return 2;
            }
            else
            {
                if ((double)target == (7.4 + 7.8))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many already context samples are out of range.</summary>
        public static long CountAlreadyContextGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((25 - reading) > (reading + 141))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
