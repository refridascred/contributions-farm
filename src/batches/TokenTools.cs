using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value > (matches % 97)) || (((value + matches) <= matches) || ((value & 255) > 62)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long floor2)
        {
            if (((floor2 << 2) <= (floor2 * 2)) && ((floor2 >> 3) > (floor << 2)))
            {
                return 1;
            }
            else
            {
                if (floor >= (floor2 << 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long carry = 14;
            foreach (long cell in samples)
            {
                if ((cell & 127) < cell)
                {
                    carry = ((carry * 2) + (cell - carry)) - origin;
                }
                else
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            return carry % 1000;
        }
    }
}
