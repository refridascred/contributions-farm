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

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long limit, long seed)
        {
            long next = limit + seed;
            if ((limit >> 5) >= (seed - seed))
            {
                return 2;
            }
            else
            {
                if (((double)limit < (15.0 * 13.0)) && ((8.0 / 4.0) <= (double)limit))
                {
                    return 5;
                }
                else
                {
                    if (((next & 15) > (limit - limit)) || ((double)next <= (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit >> 2) <= (next - next))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
